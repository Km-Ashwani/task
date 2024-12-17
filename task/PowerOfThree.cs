using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class PowerOfThree
    {
        public void Show()
        {
            // Input: Exponent
            double exponent = 4;  // You can change this to any value you want

            // Calculate power of 3 using Math.Pow
            double result = Math.Pow(3, exponent);

            Console.WriteLine($"3 raised to the power of {exponent} is: {result}");
        }
    }
}
