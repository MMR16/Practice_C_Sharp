using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Birds birds = new Birds();
            

            Dogs dogs = new Dogs();
          

        }
    }

    class Animal
    {
        public string animalName;
        public DateTime animalBdate;

        public void feedAnimal() { 
        
        }
    }

    class Dogs:Animal
    {
        public string dogBreed;
        public string dogInteligence;
        public bool isEsyToTrain;
    }

    class Birds:Dogs
    {
        public string birdColor;
        public string birdCountry;
    }


}
