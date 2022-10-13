using System;
namespace HelloWorldOne
{
    public class MyMath
    {
        public int cheng(int a,int b)
        {
            return a * b;
        }
        public int jia(int a,int b)
        {
            return a + b;
        }
        public int jian(int a,int b)
        {
            return a - b;
        }
        public int chu(int a, int b)
        {
            return a / b;
        }
    }
    class HelloWorld

    {

        static void Main(string[] args)
        {
            MyMath mymath = new MyMath();
            Console.WriteLine(mymath.jia(1, 2));
            Console.WriteLine(mymath.jian(1, 2));
            Console.WriteLine(mymath.cheng(1, 2));
            Console.WriteLine(mymath.chu(4, 2));

        }
    }
}
