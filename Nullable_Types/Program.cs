using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct is value type don't accept Null
            //Class is Ref type And Accept Null
            Console.WriteLine("----------- nullable ?-----------\n");
            DateTime? date = null;
            Console.WriteLine(date);

            int? N = null;
            Console.WriteLine(N);

            //class
            string S = null;
            Console.WriteLine(S);

            Char? C = null;
            Console.WriteLine(C);

            //int N3 = (int)N;
            int N2 =Convert.ToInt32(N);
            Console.WriteLine(N2);
            //Console.WriteLine(N3);

            Console.WriteLine("----------- null Colising ??-----------\n");

            int? Num = null;
            int Num2 = Num??50;
            string SS = S??"null";
            Console.WriteLine(Num2);
            Console.WriteLine(SS);

            Console.ReadKey();
        }
    }
}
