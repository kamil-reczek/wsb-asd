using System;

namespace SearchAlgorithms
{
    public static class Helper
    {
        /// <summary>
        /// Generate int[] table with ascending order of elements
        /// </summary>
        /// <param name="size">Size of the table to be generated</param>
        /// <returns>Sorted int[] table</returns>
        public static int[] GenerateSortedIntTable(int size)
        {
            int[] r = new int[size];
            for (int i = 0; i < r.Length; i++)
            {
                r[i] = i;
            }

            return r;
        }

        /// <summary>
        /// Generate int[] table filled with random integers
        /// </summary>
        /// <param name="size">Size of the table to be generated</param>
        /// <param name="maxVal">The random element x in the table will be in range [0, maxVal) </param>
        /// <returns>int[] table</returns>
        public static int[] GenerateRandomIntTable(int size, int maxVal)
        {
            Random rnd = new Random();
            int[] r = new int[size];
            for (int i = 0; i < r.Length; i++)
            {
                r[i] = rnd.Next(maxVal);
            }

            return r;
        }
    }
}