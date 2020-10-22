using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList L = new ArrayList();
            //L.Add(1);
            //L.Add(2);
            //L.Add(3);
            //L.Add(4);
            //L.Add("Ahmed");
            //L.Add("Ali");
            //for (int i = 0; i < L.Count; i++)
            //{
            //    Console.WriteLine(L[i]);
            //}


            ////Hashtable Key-value pair
            Hashtable H = new Hashtable();

            //H.Add(1, 1);
            //H.Add(2, "Ahmed");
            //H.Add(3, 9);
            //H.Add(4, DateTime.Now);
            //H.Add(5, 'M');
            //foreach (DictionaryEntry item in H)
            //{
            //    Console.WriteLine(item.Value);
            //    //Console.WriteLine(item.Key);
            //}
            //Console.WriteLine("===============================");
            ////length
            //Console.WriteLine(H.Count);
            //Console.WriteLine("===============================");

            ////remove
            //H.Remove(3);
            //foreach (DictionaryEntry item in H)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //// Contains
            //if (H.Contains(5))
            //{

            //}
            //Console.WriteLine("===============================");
            //Console.WriteLine("===============================");

            ////copy to array list
            //ArrayList Arr = new ArrayList(H.Values);
            //foreach (var item in Arr)
            //{
            //Console.WriteLine(item);

            //}

            ////SortedList
            //SortedList sorted = new SortedList();
            //sorted.Add('a', 1);               //1,1
            //sorted.Add('b', "Ahmed");        //2,Ahmed
            //sorted.Add('c', 9);
            //sorted.Add('d', DateTime.Now);
            //sorted.Add('e', 'M');


            //foreach (DictionaryEntry item in sorted)
            //{
            //    Console.WriteLine(item.Value);
            //    Console.WriteLine(item.Key);

            //}
            //Console.WriteLine("*********************");
            //for (int i = 0; i < sorted.Count; i++)
            //{
            //    Console.WriteLine(sorted.GetKey(i));
            //    Console.WriteLine(sorted.GetByIndex(i));

            //}

            //Console.WriteLine("*********************");
            //Console.WriteLine(sorted['d']);
            ////copy to arraylist
            //Console.WriteLine("***********array list**********");

            //ArrayList array = new ArrayList(sorted.Values);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            /////////////////stack
            ///LIFO

            //Stack S = new Stack();
            //S.Push("MMR");
            //S.Push(1);
            //S.Push('q');
            //S.Push(DateTime.Now);
            //Console.WriteLine("***********stack**********");

            //foreach (var item in S)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("*********** removing from stack**********");
            ////removing
            //S.Pop();

            //foreach (var item in S)
            //{
            //    Console.WriteLine(item);
            //}

            /////////////////queues
            ///FIFo

            //Queue Q = new Queue();
            //Q.Enqueue("MMR");
            //Q.Enqueue(1);
            //Q.Enqueue('q');
            //Q.Enqueue(DateTime.Now);
            //Console.WriteLine("***********stack**********");

            //foreach (var item in Q)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("*********** removing from stack**********");
            ////removing
            //Q.Dequeue();

            //foreach (var item in Q)
            //{
            //    Console.WriteLine(item);
            //}


            ///////////////Bitarray
            /////
            //bool[] boolarr = new bool[4];
            //boolarr[0] = true;
            //boolarr[1] = false;
            //boolarr[2] = true;
            //boolarr[3] = false;

            //BitArray bit = new BitArray(4);//index
            //BitArray array = new BitArray(boolarr);

            //bit.Set(0,true);
            //bit.Set(1, true);
            //bit.Set(2, false);
            //bit.Set(3, false);

            //foreach (var item in bit)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("*--------------------");
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //// And - Or - Not
            //BitArray Result = new BitArray(4);
            //Console.WriteLine("*------------And-----");
            //Result = bit.And(array);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("*------------Or-----");
            //Result = bit.Or(array);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("*------------Not-----");
            //Result = bit.Not();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            /////////Generic
            ///List

            // ICollection<int> vs = new List<int>();

            // List<Names> Slis = new List<Names>();



            //List<Names> Slist = new List<Names>() { 
            //new Names{Age=20,Name="Ahmed",Birthday=DateTime.Now},
            //new Names{Age=30,Name="Mostafa",Birthday=DateTime.Now},
            //new Names{Age=22,Name="Mahmoud",Birthday=DateTime.Now},
            //new Names{Age=33,Name="Alaa",Birthday=DateTime.Now},
            // };
            // foreach (var item in Slist)
            // {
            //     Console.WriteLine(item.Name+"       "+item.Age+"         "+item.Birthday);
            // }


            //    SortedDictionary<int, string> Colors = new SortedDictionary<int, string>()
            //{
            //        { 1,"red" },
            //        { 2,"green" },
            //        { 3,"blue" },
            //        { 4,"gray" },

            //};

            //    Console.WriteLine(Colors[3]);
            //    Colors.Remove(1);
            //    Console.WriteLine(Colors.Count);

            //    Colors.Clear();
            //    Console.WriteLine(Colors.Count);

            //    Stack<int> ram = new Stack<int>();
            //    ram.Push(10);




            ///Key Value Pair +List
            ///
            //    Console.WriteLine(Program.KeyValueP().Value);
            //}


            //public static KeyValuePair<int, string> KeyValueP()
            //{
            //    int a = 1;
            //    string b = "MMR";
            //    return new KeyValuePair<int, string>(a, b);

            /////////////////////////////////////////////////////////////////////////


            Console.ReadKey();
        }

        class Names
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public DateTime Birthday { get; set; }
           
        }

      
    }
}
