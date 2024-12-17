using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class fibonacci
    {
        public void Find()
        {
            Console.Write("Enter the number of terms for Fibonacci Series: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            Console.WriteLine("Fibonacci Series:");

            int first = 0, second = 1, next;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(first + " ");
                next = first + second;
                first = second;
                second = next;
            }

            Console.WriteLine();
        }
    }
}
