using System;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tracks the number of primes calculated
            int primeCount = 0;
            for (int i = 1;  primeCount <= 1000; i++)
            {
                int divCount = 0;
                for (int div = i - 1; div >= 2; div--)
                {
                    if (i % div == 0)
                    {
                        divCount++;
                    }
                }

                if (divCount == 0)
                {
                    primeCount++;
                    Console.Write(i + " ");
                }
            }
        }
    }
}