using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 22;
            decimal y = 0;
            Debug.WriteLine(x);

            try
            {
                decimal result = x / y;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
            Console.WriteLine("After");
            Console.ReadKey();
        }
    }
}
