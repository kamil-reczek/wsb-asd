namespace SortingAlgorithms.algorithms.impl
{
    public class SelectionSort : ASorting
    {
        // Constructor

        public override void Sort(int[] tab)
        {
            uint k;
            for (uint i = 0; i < (tab.Length - 1); i++)
            {
                int temp = tab[i];
                k = i;
                for (uint j = i + 1; j < tab.Length; j++)
                    if (tab[j] < temp)
                    {
                        k = j;
                        temp = tab[j];
                    }

                tab[k] = tab[i];
                tab[i] = temp;
            }
        }
    }
}