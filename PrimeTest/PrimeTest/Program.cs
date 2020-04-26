using System;
using System.Numerics;

namespace PrimeTest
{
    class Program
    {
        private static BigInteger[] primes =
            {100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399};
        
        private static bool IsPrimeExample(BigInteger n)
        {
            if (n < 2) return false;
            else if (n < 4) return true;
            else if (n % 2 == 0) return false;
            else
            {
                for (BigInteger i = 3; i < n / 2; i += 2)
                {
                    if (n % i == 0) return false;
                }
            }

            return true;
        }
        
        private static bool IsPrimeDecent(BigInteger n)
        {
            if (n < 2) return false;
            else if (n < 4) return true;
            else if (n % 2 == 0) return false;
            else
            {
                for (BigInteger i = 3; i * i <= n; i += 2)
                {
                    if (n % i == 0) return false;
                }
            }

            return true;
        }
        
        static void Main(string[] args)
        {
            // Testing for small number
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"Number {i} is prime: {IsPrimeDecent(i)}");
            }
            
        }
    }
}