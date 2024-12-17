using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Armstrong2
    {
        public void Armst()
        {
            Console.WriteLine("Armstrong numbers between 1 and 1000 are:");

            for (int num = 1; num <= 1000; num++)
            {
                int sum = 0;
                int temp = num;
                int digits = 0;

                // Calculate the number of digits
                while (temp > 0)
                {
                    digits++;
                    temp /= 10;
                }

                temp = num;

                // Calculate the sum of the power of digits
                while (temp > 0)
                {
                    int digit = temp % 10;
                    sum += (int)Math.Pow(digit, digits);
                    temp /= 10;
                }

                // Check if the sum equals the original number
                if (sum == num)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
