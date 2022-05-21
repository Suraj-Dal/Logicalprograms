using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal static class Temperature
    {
        public static void celToFah()
        {
            Console.WriteLine("Enter the teperature in degree celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine(c + " Degree Celsius in Fahrenheit is: " + f);
            
        }
        public static void FahToCel()
        {
            Console.WriteLine("Enter the teperature in degree Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine(f + " Degree Fahrenheit in Celsius is: " + c);

        }
    }
}
