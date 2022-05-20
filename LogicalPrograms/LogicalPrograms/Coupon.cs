using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Coupon
    {
        public void getCoupon()
        {
            int count = 1, flag;
            Console.WriteLine("Enter no. of distinct coupon numbers you want: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] coupon = new int[n];
            Random random = new Random();
            int value = random.Next(1, n + 1);
            coupon[0] = value;

            for (int i = 1; i <= n; i++)
            {
                flag = 0;
                i--;
                value = random.Next(1, n + 1);
                count++;

                for (int j = 0; j < i; j++)
                {
                    if (value == coupon[j])
                        flag = 1;
                }

                if (flag == 0)
                {
                    coupon[i] = value;
                    Console.WriteLine("Distinct coupon is: "+ value);
                    i++;
                }

            }
            Console.WriteLine("Total random no. needed to generate distinct coupon is: " + count);
        }
    }
}
