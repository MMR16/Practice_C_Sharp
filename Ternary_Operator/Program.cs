using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = 10; y = 30; z = 40;
            Console.WriteLine(x < y ? $"{x} is Smaller than {y}": $"{z}");
            Console.WriteLine(IsAdmin()?"Welcome Admin":"Try Again");

            Console.ReadKey();
        }

        static bool IsAdmin()
        {
            return true;
        }
    }
}
