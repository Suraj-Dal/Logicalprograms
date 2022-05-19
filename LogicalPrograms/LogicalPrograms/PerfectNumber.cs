using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void perfect()
        {
            int number, sum = 0, n;
            Console.WriteLine("Enter the Number:");
            number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                    if (sum != number)
                    Console.WriteLine(sum);
                }
            }
            if (sum == number)
                Console.WriteLine("Number is perfect number.");
            else
                Console.WriteLine("Number is not a perfect number.");
        }
    }
}
