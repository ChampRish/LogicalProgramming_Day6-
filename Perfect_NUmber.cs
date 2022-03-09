using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Day06
{
    public class Perfect_NUmber
    {
        public static void DisplayPerfectNumber()
        { 
          int n, i, sum;
          int mn, mx;

            Console.Write("Find perfect numbers within a given number of range:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the starting range or number : ");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the ending range of number : ");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Perfect numbers within the given range : ");
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i<n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
                Console.Write("\n");
        }
    }
}
