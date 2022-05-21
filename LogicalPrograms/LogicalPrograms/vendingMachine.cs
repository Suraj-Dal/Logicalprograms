using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class vendingMachine
    {
        public static void getChange()
        {
            int[] notes = new int[] {1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("Enter amount to get change.");
            int amt = Convert.ToInt32(Console.ReadLine());
            int i = 0, total = 0;
            Console.WriteLine("Notes given in change are:");
            while (amt != 0)
            {
                int change = amt / notes[i];
                int rem = amt % notes[i];
                amt = rem;
                total += change;
                if (change != 0)
                Console.WriteLine(change +" Notes of "+ notes[i]);
                i++;
            }
            Console.WriteLine("Total no. of notes needed."+ total);
        }
    }
}
