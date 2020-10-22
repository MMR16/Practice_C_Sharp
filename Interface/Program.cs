using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs d = new Dogs();
            Cats cats = new Cats();
            Ea e = new Ea();
            e.Eat();
            Console.ReadKey();
           
        }
    }

    interface IDogsCommand : IAnimal
    {
        void Stay();
        void Attack();
        int MyProperty { get; set; }
       

    }

    class Dogs : IDogsCommand
    {
        public string DogBreed { get; set; }
        public void Stay() { }
        public void Attack() { }
        public int MyProperty { get; set; }
        public void Run() { }
    }

    class Cats : Dogs, IDogsCommand
    {

    }

    interface IAnimal
    {
        void Run();
  
    }

    class Ea:Ah
    {
public override void Eat()
        {
            Console.WriteLine("Ear");
        }
    }
    abstract class Ah
    {

        public abstract void Eat();
       
        
    }
}
