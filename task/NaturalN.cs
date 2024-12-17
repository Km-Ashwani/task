using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class NaturalN
    {
        public void Naturaln()
        {
            int sum = 0;

            // Calculate the sum of the first 50 natural numbers
            for (int i = 1; i <= 50; i++)
            {
                sum += i;
            }

            Console.WriteLine("The sum of the first 50 natural numbers is: " + sum);
        }
    }
}
