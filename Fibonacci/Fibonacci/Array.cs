namespace Fibonacci
{
    public class Array : Testing
    {
        public override ulong findFibonacciNumber(ulong n)
        {
            switch (n)
            {
                case 0: return 0;
                case 1: return 1;
                default:
                {
                    ulong[] fib = new ulong[n + 1];
                    fib[0] = 0;
                    fib[1] = 1;
                    for (ulong i = 2; i <= n; i++)
                    {
                        fib[i] = fib[i - 1] + fib[i - 2];
                    }

                    return fib[n];
                }
            }
        }

        public override ulong findFibonacciNumberOper(ulong n, out ulong operCount)
        {
            operCount = 1;
            switch (n)
            {
                case 0: return 0;
                case 1: return 1;
                default:
                {
                    operCount++;
                    ulong[] fib = new ulong[n + 1];
                    fib[0] = 0;
                    fib[1] = 1;
                    for (ulong i = 2; i <= n; i++)
                    {
                        operCount++;
                        fib[i] = fib[i - 1] + fib[i - 2];
                    }

                    return fib[n];
                }
            }
        }

        public Array() : this("array")
        {
        }

        private Array(string methodName) : base(methodName)
        {
        }
    }
}