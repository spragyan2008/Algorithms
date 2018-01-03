using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonnaci
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(args[0]);
            int n = 4;

            FibonnaciNumber(n);

            Console.WriteLine("");
        }

        private static int FibonnaciNumber(int n)
        {
            int result = 0;
            if (n <= 0)
            {
                result = 0;
            }
            else if (n == 1)
            {
                result = 1;
            }
            else
            {
                result = FibonnaciNumber(n - 1) + FibonnaciNumber(n - 2);
            }

            Console.Write("{0} ", result);
            return result;
        }
    }
}
