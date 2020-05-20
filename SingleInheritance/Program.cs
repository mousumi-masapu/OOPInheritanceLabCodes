using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();//Multiple Inheritance
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            Dog dog = new Dog();//Single Inheritance
            dog.Bark();
            dog.Eat();
            Cat cat = new Cat();//Heirarchial Inheritance
            cat.Meow();
            cat.Eat();
                
        }
    }
}
