using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Lambda
{
    delegate void dis();
    delegate void displ(int h);
    class Program
    {
        static void Main(string[] args)
        {
            dis name = Display;
            name();

            displ Num = Display;
            Num(50);
            Console.WriteLine("********************");
            //Anonymous
            dis name2y = delegate
            {
                Console.WriteLine("Display from anonymous");

            };
            name2y();

            displ Num4 = delegate (int x) { Console.WriteLine("Display Number from anonymous "+x); };
            Num4(8985);

            Console.WriteLine("********************");

            //Lambda Expression
            dis names = () => Console.WriteLine("display name from lambda");
            names();

            displ Num2 = n => Console.WriteLine("from lambda your number is " + n);
            Num2(88);

            //Lambda Expression
            List<int> list = new List<int>
            {5,6,8,5,2,1,3,65,5,8,6,2,3,69,8,7,69,9,6};

            var oddNumers = list.Where(n=>n%2 !=0);
            var evenNumbers = list.Where(w=>w%2 ==0);
            Console.WriteLine("Odd Numbers");
            foreach (var item in oddNumers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Even Numbers");
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            int y = 20;
            Console.WriteLine(y.greater_20());
        }

        public static void Display()
        {
            Console.WriteLine("Display Function");
        }

        public static void Display(int g)
        {
            Console.WriteLine("your number is " + g);
        }

    }






    //Extension Method
    public static class intiger
    {
        public static bool greater_20(this int x)
        {
            return x > 50;
        }
    }

}
