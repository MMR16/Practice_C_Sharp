using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            loop(sbyte.MaxValue);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch.Start();
            loop(float.MaxValue);
            stopwatch.Stop();
            Console.WriteLine(stopwatch2.Elapsed.TotalSeconds);
            Console.WriteLine("Ticks is 100 nano second,100 million ticks in second   " + stopwatch2.Elapsed.Ticks);

            Console.ReadKey();
        }

        static void loop(float x)
        {
            for (int i = 0; i < x; i++)
            {

            }
            Console.WriteLine("End");
        }
    }
}
