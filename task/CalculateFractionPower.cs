using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class CalculateFractionPower
    {
        public void Calculate()
        {
            // Input: base and fractional power
            double baseNumber = 16;
            double exponent = 0.5; // This is equivalent to the square root

            // Calculate fractional power using Math.Pow()
            double result = Math.Pow(baseNumber, exponent);

            Console.WriteLine($"The result of {baseNumber} raised to the power of {exponent} is: {result}");
        }
    }
}
