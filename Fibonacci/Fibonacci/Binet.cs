using System;

namespace Fibonacci
{
    public class Binet : Testing
    {
        public override ulong findFibonacciNumber(ulong n)
        {
            return Convert.ToUInt64(1 / Math.Sqrt(5) * (Math.Pow(0.5*(1 + Math.Sqrt(5)), n) - Math.Pow(0.5*(1 - Math.Sqrt(5)), n)));
        }

        public override ulong findFibonacciNumberOper(ulong n, out ulong operCount)
        {
            operCount = 1;
            return Convert.ToUInt64(1 / Math.Sqrt(5) * (Math.Pow(0.5*(1 + Math.Sqrt(5)), n) - Math.Pow(0.5*(1 - Math.Sqrt(5)), n)));
        }

        public Binet() : this("binet")
        {
        }

        private Binet(string methodName) : base(methodName)
        {
        }
    }
}