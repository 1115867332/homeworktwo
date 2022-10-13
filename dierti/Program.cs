using System;
namespace HelloWorldOne
{
    class People
    {
        private int num;
        private int age;
        private string name;
        private string zhiwei;

        public People(int num, int age, string name, string zhiwei)
        {
            Num = num;
            Age = age;
            Name = name;
            Zhiwei = zhiwei;

            Console.WriteLine(num + " " + age + " " + name+ " " + zhiwei);
        }

        public int Num { get => num; set => num = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string Zhiwei { get => zhiwei; set => zhiwei = value; }
    }
    class HelloWorld
    {
        static void Main(string[] args)
        {
            People peo = new People(1,19,"赵嘉琦","大学生");
        }
    }
}
