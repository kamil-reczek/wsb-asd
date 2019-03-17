using System;

namespace Transpose
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = Transpose.readMatrix();
            Transpose.displayMatrix(m);
            Transpose.displayMatrix(Transpose.transposeMatrix(m));

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}