using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Schema;

namespace SearchAlgorithms
{
    class Program
    {
        /// <summary>
        /// Simple (linear) search algorithm, that looks for an int element in int[] table.
        /// </summary>
        /// <param name="tab">Table of int, that will scanned</param>
        /// <param name="element">Int that will be looked</param>
        /// <returns>Return the first occurence of the looked element. If not found returns -1</returns>
        private static int SimpleSearch(int[] tab, int element)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == element) return i;
            }

            return -1;
        }

        /// <summary>
        /// Binary search algorithm, that looks for an int element in int[] table.
        /// </summary>
        /// <param name="tab">Table of int, that will scanned. Must be sorted.</param>
        /// <param name="element">Int that will be looked</param>
        /// <returns>Return the first occurence of the looked element. If not found returns -1</returns>
        private static int BinarySearch(int[] tab, int element)
        {
            int left = 0;
            int right = tab.Length - 1;
            int mid;
            while (left <= right)
            {
                mid = (right + left) / 2;
                if (tab[mid] == element) return mid;
                else if (tab[mid] < element) left = mid + 1;
                else right = mid - 1;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            // Testing if algorithms works
            int[] sampleTab = Helper.GenerateSortedIntTable(11);
            for (int i = 0; i <= sampleTab.Length; i++)
            {
                var element = i < sampleTab.Length ? sampleTab[i] : sampleTab.Length;

                Console.WriteLine(
                    $"LIN: {i} == {SimpleSearch(sampleTab, element)}: {i == SimpleSearch(sampleTab, element)}");
                Console.WriteLine(
                    $"BIN: {i} == {BinarySearch(sampleTab, element)}: {i == BinarySearch(sampleTab, element)}");
            }

            Console.WriteLine();
            sampleTab = Helper.GenerateRandomIntTable(11, 50);
            // Sort sampleTab, so it can be used with binary search
            Array.Sort(sampleTab);
            for (int i = 0; i <= sampleTab.Length; i++)
            {
                var element = i < sampleTab.Length ? sampleTab[i] : 50;

                Console.WriteLine(
                    $"LIN: {i} == {SimpleSearch(sampleTab, element)}: {i == SimpleSearch(sampleTab, element)}");
                Console.WriteLine(
                    $"BIN: {i} == {BinarySearch(sampleTab, element)}: {i == BinarySearch(sampleTab, element)}");
            }

            // Measure average search time time for 2^28 elements table
            Stopwatch st = new Stopwatch();
            sampleTab = Helper.GenerateSortedIntTable((int) Math.Pow(2, 28));
            st.Reset();
            st.Start();
            foreach (var t in sampleTab)
            {
                BinarySearch(sampleTab, t);
            }

            st.Stop();
            long totalTime = st.ElapsedTicks;
            Console.WriteLine($"Total exec time: {totalTime}, average search time: {totalTime / sampleTab.Length}");
        }
    }
}