using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Day06
{
    public class Coupon_Numbers
    {
        public static void DisplayCouponNumbers()
        {
          
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[6];
                Random random = new Random();
                //  Console.WriteLine(random.Next(chars.Length));

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);
                Console.WriteLine("Coupon Number Generated : " + finalString);
            }
        }
    }
}
