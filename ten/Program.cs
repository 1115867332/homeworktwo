using System;

namespace HelloWorldOne
{
    abstract class Duck
    {
        public string Name { get; set; }
        public void speak()
        {
            Console.WriteLine("鸭子都会叫！");
        }
        public void swim()
        {
            Console.WriteLine("鸭子都会游泳！");
        }
        public void display()
        {
            Console.WriteLine("这是一只{0}", Name);
        }
        public void fly()
        {
            Console.WriteLine("{0}鸭子会飞！", Name);
        }
    }
    class MailardDuck : Duck
    {
        public MailardDuck()
        {
            Name = "MailardDuck";
        }
        public new void swim()
        {
            Console.WriteLine("{0}鸭子不会游泳！但是好吃", Name);
        }
    }
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            Name = "RedheadDuck";
        }

    }
    class RobberDuck : Duck//橡皮鸭
    {
        public RobberDuck()
        {
            Name = "RobberDuck";
        }
        public new void fly()
        {
            Console.WriteLine("{0}鸭子不会飞！", Name);
        }
    }
    class HelloWorld

    {


        static void Main(string[] args)
        {
            MailardDuck mailardDuck = new MailardDuck();

            RobberDuck robberDuck = new RobberDuck();
            mailardDuck.display();
            mailardDuck.swim();
            robberDuck.display();
            robberDuck.fly();
        }
    }
}