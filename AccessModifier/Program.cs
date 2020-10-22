using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dogs = new Dogs();
            dogs.InternalFn();
            dogs.PublicFn();
            dogs.ProtectedinternalFn();

            Cats cats = new Cats();
            cats.InternalFn();
            cats.PublicFn();
            cats.ProtectedinternalFn();
        }

        class Animal
        {
            private string privateVar;
            public string publicVar;
            internal string internalVar;
            protected string protectedVar;
            protected internal string protectedinternalVar;
            private void PrivateFn() { }
            public void PublicFn() { }
            internal void InternalFn() { }
            protected void ProtectedFn() { }
            protected internal void ProtectedinternalFn() { }
        }
        class Dogs : Animal
        {
            Dogs dogs = new Dogs();
            void feeding()
            {
                dogs.ProtectedinternalFn();
                dogs.ProtectedFn();// protected in drived class only
                dogs.InternalFn();
                dogs.PublicFn();
            }
        }
        class Cats:Dogs {
            Animal animal = new Animal();
            void run()
            {
                animal.InternalFn();
                animal.PublicFn();
                animal.ProtectedinternalFn();
                
            }
        }

    }
}
