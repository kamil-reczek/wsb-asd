using System;
using System.Diagnostics;

namespace Fibonacci
{
    public abstract class Testing
    {
        private readonly int iter = 10;
        private String methodName;
        public abstract ulong findFibonacciNumber(ulong n);
        public abstract ulong findFibonacciNumberOper(ulong n, out ulong operCount);

        public Testing(String methodName)
        {
            this.methodName = methodName;
        }
        
        public String timeTesting(ulong n)
        {
            long min = long.MaxValue;
            long max = long.MinValue;
            long timeElapsed = 0;
            ulong result = 0;
            for (int i = 0; i < iter + 2; i++)
            {
                long start = Stopwatch.GetTimestamp();
                result = findFibonacciNumber(n);
                long end = Stopwatch.GetTimestamp();
                long iterTimeElapsed = end - start;
                timeElapsed += iterTimeElapsed;
                if (iterTimeElapsed > max) max = iterTimeElapsed;
                if (iterTimeElapsed < min) min = iterTimeElapsed;
            }

            return n + ";" + result + ";" + methodName + ";time;" + ((timeElapsed - (min + max)) / iter);
        }

        public String operationTesting(ulong n)
        {
            ulong operCount = 0;
            ulong result = findFibonacciNumberOper(n, out operCount);
            return n + ";" + result + ";" + methodName + ";oper;" + operCount;
        }
    }
}