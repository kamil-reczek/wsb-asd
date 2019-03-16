namespace Fibonacci
{
    public class Iterative : Testing
    {
        public override ulong findFibonacciNumber(ulong n)
        {
            switch (n)
            {
                case 0: return 0;
                case 1: return 1;
                default:
                {
                    ulong fib0 = 0;
                    ulong fib1 = 1;
                    ulong fib = 0;
                    while (n >= 2)
                    {
                        fib = fib0 + fib1;
                        fib0 = fib1;
                        fib1 = fib;
                        n--;
                    }

                    return fib;
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
                    ulong fib0 = 0;
                    ulong fib1 = 1;
                    ulong fib = 0;
                    while (n >= 2)
                    {
                        operCount++;
                        fib = fib0 + fib1;
                        fib0 = fib1;
                        fib1 = fib;
                        n--;
                    }

                    return fib;
                }
            }
        }

        public Iterative() : this("iterative")
        {
        }

        private Iterative(string methodName) : base(methodName)
        {
        }
    }
}