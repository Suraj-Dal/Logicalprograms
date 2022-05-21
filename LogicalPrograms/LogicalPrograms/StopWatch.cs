using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        public void watch()
        {

            Console.WriteLine("Enter 1 to start timer.");
            Stopwatch stopWatch = new Stopwatch();
            
            int start = Convert.ToInt32(Console.ReadLine());

            if (start == 1)
                stopWatch.Start();

            Console.WriteLine("Enter 0 to stop timer.");
            int stop = Convert.ToInt32(Console.ReadLine());
            if (stop == 0)
                stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("Time Elapsed: " + ts.TotalSeconds);
        }
    }
}
