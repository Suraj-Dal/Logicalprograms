using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Reverse
    {
        public void perform()
        {
            int number, reverse = 0, rem;
            Console.WriteLine("Enter number to reverse:");
            number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number /= 10;
            }
            Console.WriteLine("Reversed Number is: " + reverse);
        }
    }
}
