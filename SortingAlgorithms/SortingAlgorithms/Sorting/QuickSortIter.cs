namespace SortingAlgorithms
{
    public class QuickSortIter : ASorting
    {
        public QuickSortIter()
        {
            Type = "quicksort iter";
        }

        public override void sort(int[] t)
        {
            int i, j, l, p, sp;
            int[] stos_l = new int [t.Length],
                stos_p = new int [t.Length];
            sp = 0;
            stos_l[sp] = 0;
            stos_p[sp] = t.Length - 1;

            do
            {
                l = stos_l[sp];
                p = stos_p[sp];
                sp--;

                do
                {
                    int x;
                    i = l;
                    j = p;
                    x = t[(l + p) / 2];
                    do
                    {
                        while (t[i] < x) i++;
                        while (x < t[j]) j--;
                        if (i <= j)
                        {
                            int buf = t[i];
                            t[i] = t[j];
                            t[j] = buf;
                            i++;
                            j--;
                        }
                    } while (i <= j);

                    if (i < p)
                    {
                        sp++;
                        stos_l[sp] = i;
                        stos_p[sp] = p;
                    }
                    p = j;
                } while (l < p);
            } while (sp >= 0);
        }
    }
}