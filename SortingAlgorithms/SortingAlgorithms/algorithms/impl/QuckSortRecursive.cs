using System;

namespace SortingAlgorithms.algorithms.impl
{
    public class QuckSortRecursive : ASorting
    {
        // Constructor

        public override void Sort(int[] tab)
        {
            Sort(tab, 0, tab.Length - 1);
        }
        
        Random _random = new Random();
        private void Sort(int[] tab, int left, int right)
        {
            int i, j, x;
            i = left;
            j = right;
            //x = tab[left];
            x = tab[left];

            do
            {
                while (tab[i] < x) i++;
                while (x < tab[j]) j--;
                if (i <= j)
                {
                    int buf = tab[i];
                    tab[i] = tab[j];
                    tab[j] = buf;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j) Sort(tab, left, j);
            if (i < right) Sort(tab, i, right);
        }
    }
}