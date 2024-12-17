using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Absolute
    {
        public void absolute()
        {
            Console.Write("Enter a number to find its absolute value: ");
            int number = int.Parse(Console.ReadLine());

            int absoluteValue = Math.Abs(number);
            Console.WriteLine("The absolute value of " + number + " is: " + absoluteValue);
        }
    }
}
