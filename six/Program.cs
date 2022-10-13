using System;
using System.Runtime.CompilerServices;

namespace HelloWorldOne
{
    public class Animal
    {
        public virtual  void voice()
        {

        }
    }
    public class Cat : Animal
    {
        public override void voice()
        {
            Console.WriteLine("喵喵喵？");
        }
    }
    public class Pig : Animal
    {
        public override void voice()
        {
            Console.WriteLine("哼哼哼");
        }
    }
    public class Dog : Animal
    {
        public override void voice()
        {
            Console.WriteLine("汪汪汪");
        }
    }
    public class Store
    {
        public Animal getInstance(string animal)
        {
            if (animal == "dog") return new Dog();
            else if (animal == "cat") return new Cat();
            else return new Pig();
        } 
    }
    class HelloWorld

    {


        static void Main(string[] args)
        {
            Store store = new Store();
            string s = Console.ReadLine();
            store.getInstance(s).voice();

        }
    }
}

