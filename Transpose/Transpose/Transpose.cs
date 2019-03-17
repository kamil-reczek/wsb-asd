using System;

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
                    Console.Write("Procide elemnt [" + i + ", " + j + "] = ");
                    result[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return result;

        }

        public static void displayMatrix(int[,] m)
        {
            Console.WriteLine("Displaying matrix: ");
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] transposeMatrix(int[,] m)
        {
            Console.WriteLine("Transposing matrix ...");
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
    }
}