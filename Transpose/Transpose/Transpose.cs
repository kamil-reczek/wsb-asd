using System;
using System.Diagnostics;

namespace Transpose
{
    public class Transpose
    {
        public static int[,] readMatrix()
        {
            Console.Write("Provide number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Provide number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(@"Provide element [{i},{j}] = ");
                    result[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return result;

        }
        
        public static int[,] generateIntMatrix(int rows, int cols) 
        {
            if (rows == 0 || cols == 0) throw new ArgumentOutOfRangeException("Cols and rows need to be > 0");
            Random rand = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = rand.Next(25);
            return matrix;
        }
        
        public static void displayMatrix(int[,] m)
        {
            Console.WriteLine("Displaying matrix: ");
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"{m[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static int[,] transposeMatrix(int[,] m)
        {
            int[,] t = new int[m.GetLength(1), m.GetLength(0)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    t[j, i] = m[i, j];
                }
            }

            return t;
        }

        public static int[,] transposeMatrix(int[,] m, out long counter)
        {
            counter = 0;
            int[,] t = new int[m.GetLength(1), m.GetLength(0)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    t[j, i] = m[i, j];
                    counter++;
                }
            }
            return t;
        }

        public static string measureTime(int[,] m)
        {
            Stopwatch st = new Stopwatch();
            int size = m.GetLength(0);
            int sampleSize = 10;
            long sampleTime = 0;
            long totalTime = 0;
            long minTime = long.MaxValue;
            long maxTime = long.MinValue;
            
            for (int i = 0; i < sampleSize + 2; i++)
            {
                st.Reset();
                st.Start();
                transposeMatrix(m);
                st.Stop();
                sampleTime = st.ElapsedMilliseconds;
                totalTime += sampleTime;
                if (minTime > sampleSize) minTime = sampleSize;
                if (maxTime < sampleSize) maxTime = sampleSize;
            }

            long result = (totalTime - minTime - maxTime) / sampleSize;
            return $"{size},time,{result}";
        }

        public static string measureOperations(int[,] m)
        {
            int size = m.GetLength(0);
            long counter = 0;
            transposeMatrix(m, out counter);
            return $"{size},counter,{counter}";
        }
    }
}