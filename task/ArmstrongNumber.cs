using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class ArmstrongNumber
    {
        public void Armstrong()
        {
            Console.Write("Enter a number to check if it is an Armstrong Number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsArmstrongNumber(number))
            {
                Console.WriteLine($"{number} is an Armstrong Number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong Number.");
            }
        }
        static bool IsArmstrongNumber(int num)
        {
            int originalNumber = num;
            int sum = 0;
            int digitsCount = num.ToString().Length; // Count the number of digits in the number

            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digitsCount); // Raise the digit to the power of the number of digits
                num /= 10;
            }

            return sum == originalNumber; // If sum equals the original number, it's an Armstrong number
        }
    }
}
