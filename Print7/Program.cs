using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(args[0]);

            for (int i=1; i<=n; i++)
            {
                if (Is7(i))
                {
                    Console.Write("{0} ", i);
                }
            }
        }

        private static bool Is7(int i)
        {
            if ((i % 7) == 0)
            {
                return true;
            }

            while (i > 0)
            {
                int digit = i % 10;
                if (digit == 7)
                {
                    return true;
                }

                i = i / 10;
            }

            return false;
        }
    }
}
