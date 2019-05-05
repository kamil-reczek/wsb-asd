namespace SortingAlgorithms
{
    public class InsertionSort : ASorting
    {
        public InsertionSort()
        {
            Type = "insertion";
        }

        public override void sort(int[] tab)
        {
            for (uint i = 1; i < tab.Length; i++)
            {
                uint j = i;
                int temp = tab[j];

                while ((j > 0) && (tab[j - 1] > temp))
                {
                    tab[j] = tab[j - 1];
                    j--;
                }

                tab[j] = temp;
            }
        }
    }
}