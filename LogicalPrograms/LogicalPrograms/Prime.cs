using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Prime
    {
        public void check()
        {
            Console.WriteLine("Enter no. to check whether it is prime or not:");
            int number = Convert.ToInt32(Console.ReadLine());
            int flag = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    flag++;
                }
            }
            if (flag == 2)
                Console.WriteLine(number +" is a Prime Number.");
            else
                Console.WriteLine(number +" is not a Prime Number.");
        }
    }
}
