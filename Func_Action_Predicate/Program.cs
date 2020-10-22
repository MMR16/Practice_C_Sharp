using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Action_Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            swap(a, b);

            ///Func
            /////takes 16 parameters , the last one is output type 
            ///return value
            Console.WriteLine("****************Func\n");

            Func<int, int, int> adding = AddN;
            Console.WriteLine(adding(8, 9));

            Func<int> One = AddN;
            Console.WriteLine(One());

            Func<float, float, float, float, float> AddingFloat = (q, w, e, r) => q + w + e + r;
            var x = AddingFloat(10.3f, 5.699f, 145.564f, 5.4f);
            Console.WriteLine(x);

            ///Action
            /////takes 16 parameters , the last one is output type 
            ///Doesn't return value
            ///return void
            Console.WriteLine("****************Action\n");
            Action info = Display;
            info();

            Action<int> NumInfo = Display;
            NumInfo(158848541);

            Action Lambda = () => Console.WriteLine("Lambda Expression");
            Lambda();

            Action<float> Circle = n => Console.WriteLine("the round is " + 2 * n * (Math.PI));
            Circle(5);
            Console.WriteLine("****************Predicate\n");
            Predicate<int> Compare = m => m >= 50;
            Console.WriteLine(Compare(60)); 



            Console.ReadKey();
        }

        static int AddN(int v, int j)
        {
            return v + j;
        }

        static int AddN()
        {
            int q = 10;
            int w = 35;
            int e = q + w;
            return e;
        }

        static void Display()
        {
            Console.WriteLine("Information from Display");
        }

        static void Display(int Num)
        {
            Console.WriteLine("Number from Display " + Num);
        }


        static void swap(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a is: {a}, B is {b}");
        }
    }
}
