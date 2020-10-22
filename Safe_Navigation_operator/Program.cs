using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe_Navigation_operator
{                                   //not equal null with property
    class Program
    {
        static void Main(string[] args)
        {
            Cars BMWM3 = new Cars() { Brand = "Bmw",Model="M3",Price=360000 };
            Cars MercedesAmgt = new Cars() { Brand = "Mercedes", Model = "Amgt", Price = 240000 };
            Cars FerrariEnzo = new Cars() { Brand = "Ferrari", Model = "Enzo", Price = 450000 };

            Console.WriteLine("Cars Informations\n");
            Cars.DisplayCarDetails(BMWM3);
            Cars.DisplayCarDetails(MercedesAmgt);
            Cars.DisplayCarDetails(FerrariEnzo);
            Console.WriteLine("Cars Numbers\n");
            int ?count = default;    //0
            // List<Cars> CarsNumber = null;
            List<Cars> CarsNumber = new List<Cars>();
            CarsNumber.Add(BMWM3);
            CarsNumber.Add(MercedesAmgt);
            CarsNumber.Add(FerrariEnzo);

            count = CarsNumber?.Count();
            Console.WriteLine(count);
            Console.ReadKey();
        }

    }

    class Cars
    {
        public string Brand { get; set; }
        public string  Model { get; set; }
        private Decimal price { get; set; }

        public decimal Price
        {
            get => price;
            set => price = value * 14/100;
        }

        public static void DisplayCarDetails (Cars car)
        {
            //if (car.Model!=null)
            //{
            //    Console.WriteLine(car.Model);
            //}
            // if (car.Brand!=null)
            //{
            //    Console.WriteLine(car.Brand);
            //}
            // if (car.price!=null)
            //{
            //    Console.WriteLine(car.price);
            //}
            Console.WriteLine(car?.Model);
            Console.WriteLine(car?.Brand);
            Console.WriteLine(car?.Price);

            Console.WriteLine("=============================");
        }

    }

}
