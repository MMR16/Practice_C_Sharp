using System;

//namespace Read_Calc{ 
    public class CalcAge
    {  
        public static void ReadName(string x)
        {
            Console.Write("Please Enter Your Name: "); ;
            x = Console.ReadLine();
            Console.WriteLine($"Your Name Is: {x}");
        }

        public static void Age(int q, int w, int e)
        {
            DateTime x = DateTime.Today;
            Console.WriteLine("Please Enter the Year");
             q = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Month");
             w = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Day");
             e = int.Parse(Console.ReadLine());
            DateTime z = new DateTime(q, w, e);
            Console.WriteLine($"Your Age Is: {(x - z).TotalDays / 365} Year"  );
        }
    }
//}
