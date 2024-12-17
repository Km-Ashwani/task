using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Prime
    {
        public void prime()
        {
            Console.WriteLine("Prime numbers between 1 and 100 are:");

            for (int num = 2; num <= 100; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
            static bool IsPrime(int number)
            {
                if (number <= 1)
                    return false;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        return false;
                }
                return true;
            }
        }
    }
}
