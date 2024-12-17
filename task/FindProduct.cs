using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public  class FindProduct
    {
        public void findprod()
        {
            static int Multiply(int a, int b)
            {
                // Base case: If one of the numbers is 0, the product is 0
                if (b == 0)
                    return 0;

                // Recursive case: Add 'a' to the result of Multiply(a, b-1)
                return a + Multiply(a, b - 1);
            }
        }

        //public class process
        //{
        //    public void print()
        //    {

        //    }
        //}
    }
}
