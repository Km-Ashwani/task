using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class LargestPrimeFactor
    {
        public void lgpf()
        {
            Console.Write("Enter a number to find its largest prime factor: ");
            long number = long.Parse(Console.ReadLine());

            if (number <= 1)
            {
                Console.WriteLine("No prime factors exist for numbers less than or equal to 1.");
                return;
            }

            long largestPrimeFactor = GetLargestPrimeFactor(number);
            Console.WriteLine($"The largest prime factor of {number} is: {largestPrimeFactor}");
        }
        static long GetLargestPrimeFactor(long n)
        {
            long largest = -1;

            // Remove all factors of 2
            while (n % 2 == 0)
            {
                largest = 2;
                n /= 2;
            }

            // Check for odd factors from 3 to sqrt(n)
            for (long i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    largest = i;
                    n /= i;
                }
            }

            // If n is still greater than 2, it is prime
            if (n > 2)
            {
                largest = n;
            }

            return largest;
        }
    }
}
