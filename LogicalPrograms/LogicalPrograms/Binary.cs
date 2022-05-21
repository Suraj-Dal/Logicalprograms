using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Binary
    {
        public static void getBinary()
        {
            Console.WriteLine("Enter decimal no. to convert into binary:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] binary = new int[10];
            int rem, i = 0;
            while (number > 0)
            {
                rem = number % 2;
                number /= 2;
                binary[i] = rem;
                i++;
                
            }
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
        }
    }
}
