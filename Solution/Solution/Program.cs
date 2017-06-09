using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Solution
    {
        static long Solve(int n)
        {
            long result = 0;

            while (n >= 4)
            {
                int x = (int)(n / 4);
                if (n % 4 == 0)
                {
                    for (int k = 1; k*k < x; k++)
                    {
                        if (x % k == 0)
                        {
                            result++;
                        }
                    }
                }
                n--;
            }


            //return
            return result;

        }

        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int x = 100;
            Console.WriteLine(Solve(x));
            Console.ReadKey();
        }
    }
}
