using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class PerfectNumber
    {
        public void PfNumber()
        {
            Console.Write("Enter a number to check if it is a Perfect Number: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            if (IsPerfectNumber(number))
            {
                Console.WriteLine($"{number} is a Perfect Number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a Perfect Number.");
            }
        }
        static bool IsPerfectNumber(int n)
        {
            int sum = 0;

            // Find all proper divisors
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            // Check if the sum of divisors equals the number
            return sum == n;
        }

    }
}
