using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] shape = new Shapes[5];
            shape[0] = new Shapes();
            shape[1] = new circle();
            shape[2] = new Square();
            shape[3] = new Triangle();
            shape[4] = new Line();
            foreach (var item in shape)
            {
                item.Drow();
            }

            Console.ReadKey();

        }
    }

    class Shapes
    {
        public virtual void Drow() { Console.WriteLine("Iam A simple Shape"); }
    }

    class circle:Shapes
    {
        public override void Drow() { Console.WriteLine("Iam A Circle"); }
    }

    class Square:Shapes
    {
        public new void Drow() { Console.WriteLine("Iam A Square"); }   //new keyword will use the method of base class
    }

    class Triangle:Shapes
    {
        public override void Drow() { Console.WriteLine("Iam A Triangle"); }
    }

    class Line:Shapes
    {
        public override void Drow() { Console.WriteLine("Iam A Line"); }
    }
}
