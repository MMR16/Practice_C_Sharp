using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write to file
            Directory.CreateDirectory(@"C:\EA");
            string file = @"C:\Ea\Name.txt";
            StreamWriter stream = new StreamWriter(file, append: true, Encoding.Unicode);
            stream.WriteLine("mostafa\t\t\t\tmahmoud");
            stream.WriteLine("مصطفى محمود");
            stream.Close();


            //read from file
            string fileread = @"C:\EA\Name.txt";
            StreamReader reader = new StreamReader(fileread, Encoding.Unicode);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();


            /// enum Length
            string Lang = string.Empty;
            int count = Enum.GetValues(typeof(Lang)).Length;
            for (int i = 0; i < count; i++)
            {
                Lang = Enum.GetValues(typeof(Lang)).GetValue(i).ToString();
                Console.WriteLine(Lang);
            }

            Console.ReadKey();
        }
        enum Lang
        {
            English, Arabic, russian, frinsh, german, italian
        }
    }
}
