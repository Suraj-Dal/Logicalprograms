using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class monthlyPayment
    {
        public static void calculateEMI()
        {
            Console.WriteLine("Enter no.of yeras to pay off:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter principal loan amount:");
            int pL = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of interest:");
            int rate = Convert.ToInt32(Console.ReadLine());

            int n = 12 * year;
            decimal r = (decimal)rate / 1200;
            double payment = (pL * (double)(r)) / (1 - Math.Pow(1 + (double)(r), -n));
            Console.WriteLine("Monthly Payment is: "+ payment);
        }
    }
}
