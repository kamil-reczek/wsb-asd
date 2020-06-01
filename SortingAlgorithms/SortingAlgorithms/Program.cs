using System;
using System.Reflection.Emit;
using SortingAlgorithms.algorithms;
using SortingAlgorithms.data;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part I and II (Part III (QuickSort) looks similar)
            // Fill this array with proper object instances
            IGenerateData[] generators = new IGenerateData[5];
            
            // Fill this array with proper object instances
            ASorting[] alorithms = new ASorting[4];
            
            // 3 loops here:
            // 1 - iterate through table sizes,
            // 2 - generators,
            // 3 - algorithms, execute method which measures time in ASorting abstract class)
            
        }
    }
}