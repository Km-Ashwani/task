using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class AmicableN
    {
        public void amicableN()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum1 = FindDivisorSum(num1);
            int sum2 = FindDivisorSum(num2);

            if (sum1 == num2 && sum2 == num1)
            {
                Console.WriteLine($"{num1} and {num2} are amicable numbers.");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not amicable numbers.");
            }
        }
        static int FindDivisorSum(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
