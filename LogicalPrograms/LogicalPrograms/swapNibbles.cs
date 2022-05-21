using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class swapNibbles
    {
        public static void swap()
        {
            Console.WriteLine("Enter the Decimal no.:");
            int dec = Convert.ToInt32(Console.ReadLine());
            string bin = Convert.ToString(dec, 2);
            if (bin.Length % 2 != 0)
            {
                bin = "0" + bin;
            }
            string nibble1 = bin.Substring(0, 4);
            string nibble2 = bin.Substring(4, 4);
            Console.WriteLine("Binary no. before swapping is: "+ bin);
            string temp = nibble1;
            nibble1 = nibble2;
            nibble2 = temp;
            bin = nibble1 + nibble2;
            int swap = Convert.ToInt32(bin, 2);
            Console.WriteLine("binary no. after swapping: " + bin);
            Console.WriteLine("Decimal no. of swapped binary no. is :"+ swap);
        }
    }
}
