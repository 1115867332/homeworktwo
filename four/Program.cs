using System;
namespace HelloWorldOne
{
   public class Circle
    {
        private int r;

        public int R { get => r; set => r = value; }

        public double zhouchang()
        {
            return 2 * 3.14 * R;
        }
        public double mianji()
        {
            return 3.14 * R * R;
        }
    }
    class HelloWorld

    {
        

        static void Main(string[] args)
        {
            Circle cir = new Circle();
            cir.R = 1;
            Console.WriteLine( cir.zhouchang());
            Console.WriteLine(cir.mianji());

        }
    }
}
