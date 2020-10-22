using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void n(string var);
    public delegate void s(int d);
    public delegate void NA(string d,int t);
    public delegate T DisplayInfo<T>(T v);
   
    class Program
    {
        static void Main(string[] args)
        {
            //ddd interd = new ddd();
            //Console.WriteLine(interd.Id = 444);
            //dddd abs = new dddd();
            //Console.WriteLine(abs.MyProperty = 201455);


            //n name = new n(write);
            //name("Mostafa");

            //s num = write;
            //num(45641323);

            //NA Emp = (write);
            //Emp("MMR",26);

            //Predicate<int> pre = n => n > 10;
            //Console.WriteLine(pre(10));

            ///             Generic + Delegate
            ///             

            //calling method
            Display(55555);
            Display('d');
            Display("dsdihjf");

            //calling delegate
            DisplayInfo <int> MyNumber= Display;
            Console.WriteLine(MyNumber(11111));

            DisplayInfo<string> name = Display;
            Console.WriteLine(name("Mostafa"));
            Console.ReadKey();
        }
        //Generic
        public static T Display<T>(T val)
        {
            Console.WriteLine("WE Are Accessing Variable of type:  "+val.GetType().Name);
            return val;
        }



        public static void write(string x)
        {
            Console.WriteLine($"=============>{x}");
        }

        public static void write(int x)
        {
            Console.WriteLine($"=============>{x}");
        }
        public static void write(string n,int x)
        {
            Console.WriteLine($"=============>your name is: {n} & your age is: {x}");
        }
    }

    public interface Ic
    {
        void D();
        int MyProperty { get; set; }
    };

    abstract class AS
    {
        public abstract void F();
        public abstract int Id { get; set; }
    }

    class ddd : AS
    {
        public override int Id { get; set; }

        public override void F()
        {
            throw new NotImplementedException();
        }
    }

    class dddd : Ic
    {
        public int MyProperty { get; set; }

        public void D()
        {
            throw new NotImplementedException();
        }
    }

}
