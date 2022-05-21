using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class dayOfWeek
    {
        public void getDay()
        {
            Console.WriteLine("Enter date: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            int y = Convert.ToInt32((Console.ReadLine()));
            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Friday", "Saturday" };
            
            if (d >= 1 && m >= 1 && y >= 1000 && d <= 31 && m <= 12 && y <= 10000)
            {
                int y0 = y - (14 - m) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = m + 12 * ((14 - m) / 12) - 2;
                int d0 = (d + x + 31 * m0 / 12) % 7;
                Console.WriteLine("The day on this date is: "+ days[d0]);
            }
            else
            {
                Console.WriteLine("Enter valid date, month and year.");
                getDay();
            }

        }
    }
}
