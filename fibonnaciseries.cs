using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Day06
{
    public class fibonnaciseries
    {
        public static void Displayfibonnaciseries()
        {
            int Number1 = 0, Number2 = 1, Number3, i, Number;
            Console.WriteLine("Enter Number : ");
            Number = int.Parse(Console.ReadLine());
            Console.Write(Number1 + " " + Number2 + " ");
            for (i = 2; i < Number; i++)
            {
                Number3 = Number1 + Number2;
                Console.Write(Number3 + " ");
                Number1 = Number2;
                Number2 = Number3;
            }

        }
    }
}
