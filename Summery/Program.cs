using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summery
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Eat("s","d");

            

            Console.ReadKey();
        }
    }
    class Animal : IDo
    {
        /// <summary>
        /// Consol Wite Line Eating
        /// </summary>
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }


        /// <summary>
        /// Over Loading Eat Animal With Two Parameters
        /// </summary>
        /// <param name="a"> This Will Hold Animal Name</param>
        /// <param name="b"> This Will Hold Trainer Name</param>
        public void Eat(string a, string b)
        {
            Console.WriteLine("Animal is eating");
        }
    }
    interface IDo
    {
        void Eat();
        void Eat(string a,string b);
    }
}
