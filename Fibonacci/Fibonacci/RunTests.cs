using System;
using System.IO;

namespace Fibonacci
{
    public class RunTests
    {
        public static String resultPath = @"e:\DOCUMENTS\BITBUCKET\wsb_asd\Fibonacci\Fibonacci\TestResults\results.csv";
        
        public static void Main(string[] args)
        {
            // prepare array with different implementations of Fibonacci number
            Testing[] testings = new Testing[4];
            testings[0] = new Recursive();
            testings[1] = new Iterative();
            testings[2] = new Binet();
            testings[3] = new Array();
            
            // delete results file
            System.IO.File.Delete(resultPath);
            
            // fill results.csv with data
            using (System.IO.StreamWriter file = new StreamWriter(resultPath, true))
            {
                file.WriteLine("n;fib;method;measure;value");
                foreach (Testing test in testings)
                {
                    for (ulong i = 0; i < 45; i++)
                    {
                        file.WriteLine(test.timeTesting(i));
                        file.WriteLine(test.operationTesting(i));
                    }
                }
            }

        }
    }
}