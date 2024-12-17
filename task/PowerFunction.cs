using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class PowerFunction
    {
        public void Powerf()
        {
            // Input: Base and Range of Exponents
            int baseNumber = 3;
            int minExponent = -5; // Minimum exponent
            int maxExponent = 5;  // Maximum exponent

            Console.WriteLine($"Edge values in the power function of {baseNumber} between exponents {minExponent} and {maxExponent}:");

            // Print the edge value for the minimum exponent
            double minPower = Math.Pow(baseNumber, minExponent);
            Console.WriteLine($"{baseNumber} raised to the power of {minExponent} is: {minPower}");

            // Print the edge value for the maximum exponent
            double maxPower = Math.Pow(baseNumber, maxExponent);
            Console.WriteLine($"{baseNumber} raised to the power of {maxExponent} is: {maxPower}");
        }
    }
}
