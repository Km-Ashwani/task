using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Factorial
    {
        public void fact()
        {
            Console.Write("Enter a number to calculate its factorial: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                long factorial = 1; // Use 'long' to handle large numbers.

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"The factorial of {number} is: {factorial}");
            }
        }
    }
}
