using System;

namespace Fibonacci
{
    public class Recursive : Testing
    {
        public override ulong findFibonacciNumber(ulong n)
        {
            switch (n)
            {
                case 0: return 0;
                case 1: return 1;
                default: return findFibonacciNumber(n - 1) + findFibonacciNumber(n - 2);
            }
        }

        public override ulong findFibonacciNumberOper(ulong n, out ulong operCount)
        {
            ulong _counter = 0;

            ulong _fibRecursive(ulong m)
            {
                _counter++;
                switch (m)
                {
                    case 0: return 0;
                    case 1: return 1;
                    default: return _fibRecursive(m - 1) + _fibRecursive(m - 2);
                }
            }

            ulong results = _fibRecursive(n);
            operCount = _counter;
            return results;
        }

        public Recursive() : this("recursive")
        {
        }

        private Recursive(string methodName) : base(methodName)
        {
        }
    }
}