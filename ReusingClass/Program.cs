using System;
using System.Collections.Generic;

namespace ReusingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList r = new RandomList();
            r.Add("Mousumi");
            r.Add("Masapu");
            r.Add("Lexicon");
            r.Add("OOP");
            r.RandomString();
            for (int i = 0; i < r.Count; i++)
            {
                Console.WriteLine(r[i]);
            }
            Console.ReadKey();
        }
    }
}
