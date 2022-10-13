using System;
using System.Runtime.CompilerServices;

namespace HelloWorldOne
{
    public abstract class Animal
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public abstract void enjoy();
    }

    public class Cat : Animal
    {
        private string eyesColor;

        public string EyesColor { get => eyesColor; set => eyesColor = value; }

        public Cat(string name)
        {
            this.Name = name;
        }
        public override void enjoy()
        {
            Console.WriteLine("笑一笑");
        }
    }
    public class Dog : Animal
    {
        public string furColor;
        public string FurColor { get => furColor; set => furColor = value; }

        public Dog(string name)
        {
            this.Name = name;
        }
        public override void enjoy()
        {
            Console.WriteLine("叫一叫");
        }

    }
    public class Lady
    {
        string name;
        Animal pet;
     
        public Lady(string name, Animal pet)
        {
            this.name = name;
            this.pet = pet;
        }
        public void myPetEnjoy()
        {
            
            Console.Write(name + "养了一只" + pet.Name + "让"  + pet.Name);
            pet.enjoy();
        }
    }
    class Test

    {

        static void Main(string[] args)
        {
            Animal pet1 = new Cat("猫");
            Lady lady1 = new Lady("张女士", pet1);
            lady1.myPetEnjoy();
            Animal pet2 = new Dog("狗");
            Lady lady2 = new Lady("王女士", pet2);
            lady2.myPetEnjoy();
        }
    }
}
