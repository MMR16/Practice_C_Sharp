using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread( new ThreadStart(Thread1));
            Thread th2 = new Thread(new ThreadStart(Thread2));
            Thread th3 = new Thread(new ThreadStart(Thread1));
            Thread th4 = new Thread(new ThreadStart(Thread2));
            Thread th5 = new Thread(new ThreadStart(Thread1));
            Thread th6 = new Thread(new ThreadStart(Thread2));
            Thread th7 = new Thread(new ThreadStart(Thread1));
          
            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();
            th5.Start();
            th6.Start();
            th7.Start();
            Console.ReadKey();
        }

        public static void Thread1()
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("Thread 1 "+i);
            }
        }
        public static void Thread2()
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("Thread 2 " + i);
            }
        }
    }
}
