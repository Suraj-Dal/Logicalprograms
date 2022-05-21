using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class squareRoot
    {
        public static void findSqrt()
        {
            Console.WriteLine("Enter Number:");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;    
            double t = c;              
            
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2;
            }
            Console.WriteLine("Square root of "+ c +" is "+ t);
        }
    }
}
