using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Parm(1,2,3,4,5,6,7,8,9);
            Parm('a', 'b', 'c', 'd', 'e', 'f', 'g', 'h');
            Parm("Mostafa ", "Ali", "Omar", "Alaa");

            Console.ReadKey();
        }

        public static void Parm<T>(params T[] ts)
        {
            foreach (var item in ts)
            {
                Console.WriteLine(item);
            }

        }

    }
}
