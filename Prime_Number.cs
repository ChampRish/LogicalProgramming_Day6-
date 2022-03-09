using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Day06
{
    public class Prime_Number
    {
        public static void FindPrimeNumbers()
        {
            int n;
            int flag = 0;
            Console.WriteLine("Enter a number to decide prime or not except 0 ,1");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                }

            }
            if (flag == 0)
            {
                Console.WriteLine(n + " It is a Prime number ");
            }
            else
            {
                Console.WriteLine(n + " It is not a Prime Number");
            }
        }
    }
}       
