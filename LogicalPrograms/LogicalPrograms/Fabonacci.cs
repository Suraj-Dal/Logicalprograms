using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fabonacci
    {
        public void series()
        {
            int p1 = 0, p2 = 1, p3;
            Console.WriteLine("Enter the no. of elements: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fabonacci series is:");
            Console.WriteLine(p1 +"\n"+ p2); 
            
            for (int i = 0; i < number-2; i++) 
            {
                p3 = p1 + p2;
                Console.WriteLine(p3);
                p1 = p2;
                p2 = p3;
            }
        }
    }
}
