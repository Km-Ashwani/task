using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class CubeRoot
    {
        public void cuberoot()
        {
            Console.Write("Enter a number to find its square root: ");
            double number = double.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Square root of a negative number is undefined in real numbers.");
            }
            else
            {
                double cubeRoot = Math.Cbrt(number);
                Console.WriteLine($"The square root of {number} is: {cubeRoot}");
            }
        }
    }
}
