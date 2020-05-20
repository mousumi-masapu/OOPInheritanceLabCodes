using System;
using System.Collections.Generic;
using System.Text;

namespace StringStacking
{
    public class Program
    {
        static void Main(string[] args)
        {
       
            StackOfStrings obj = new StackOfStrings();
            obj.Push("Mousumi");
            obj.Push("Masapu");
            obj.Push("Lexicon");
            obj.Push("Stockholm");
            Console.WriteLine(obj.IsEmpty());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Peek());
            Console.ReadLine();


        }
    }
}
