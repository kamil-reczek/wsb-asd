using System;

namespace Transpose
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing if matrix generation and transposition works
            int[,] test = Transpose.generateIntMatrix(2,5);
            Transpose.displayMatrix(test);
            Transpose.displayMatrix(Transpose.transposeMatrix(test));
            
            // Measuring transposition complexity for matrices size 1k - 10k
            for (int i = 1000; i <= 10000; i += 500)
            {
                int[,] m = Transpose.generateIntMatrix(i, i);
                Console.WriteLine(Transpose.measureTime(m));
                Console.WriteLine(Transpose.measureOperations(m));
            }
        }
    }
}