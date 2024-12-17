using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class FactorN
    {
        public void factorn()
        {
            Console.Write("Enter a number to find its factors: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The factors of " + number + " are:");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
