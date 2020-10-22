using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentions_M
{
    // Must be static method in static class 
    //have the keyword this 
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int p = 440;
            float q = 415.3333f;
            string s="454576";
            Console.WriteLine(x.GreaterThanPI());

            Console.WriteLine(q.ToStr());

            Console.WriteLine(p.rev(x));

            Console.WriteLine(x.Greaterthan(p));


            Console.WriteLine(s.IsInt());

            bool Admin = false;
            Admin.IsTrue();
            Console.ReadKey();
        }
    }

    static class Extention
    {
        /// <summary>
        /// This is an Extention Function to returnt true or false
        /// </summary>
        /// <param name="number">the number must be int</param>
        /// <returns>true or false</returns>
        public static bool GreaterThanPI(this int number)
        {
            return number > Math.PI;
        }

        /// <summary>
        /// this is ageneric method to convert any thing to string
        /// </summary>
        /// <typeparam name="r"> the type of return</typeparam>
        /// <param name="number"></param>
        /// <returns>return string</returns>
        public static string ToStr<r>(this r number)
        {
            return number.ToString();
        }

        public static int rev(this int x, int y)
        {
            int temp;
            temp = y;
            x = temp;
            y = x;
            return x;
        }

        public static bool Greaterthan(this int x,int o)
        {
            return x > o;
        }

        public static bool IsInt(this string h)
        {
            bool s= int.TryParse(h, out int g);
            if (s)
            {
                Console.WriteLine($"the Number is {g}");
            }
            return s;


        }

        public static void IsTrue(this bool x)
        {
            switch (x)
            {
                case true: Console.WriteLine("This Method Is True");
                    break;
                case false: Console.WriteLine("This Methis Is False");
                    break;
            }
        }

    }
}
