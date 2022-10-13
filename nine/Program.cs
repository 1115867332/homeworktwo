using System;

namespace HelloWorldOne
{
    interface A
    {
        public double area();
    }

    interface B
    {
        public abstract void setColor(string c);
    }

    interface C : A, B
    {
        public void volume();

    }

    public class Cylinder : C{
        private int radius;
        private int height;
        private string color;

        public Cylinder(int radius, int height)
        {
            this.Radius = radius;
            this.Height = height;
        }

        public int Radius { get => radius; set => radius = value; }
        public int Height { get => height; set => height = value; }
        public string Color { get => color; set => color = value; }

        public double area()
        {
            return 3.14 * Radius * Radius;
        }
        public  void setColor(string c)
        {
            Color = c;
        }
        public void volume()
        {
            Console.WriteLine(area()*Height);
        }
    }
    class HelloWorld

    {


        static void Main(string[] args)
        {
            string s = "绿色";
            Cylinder cylinder = new Cylinder(1, 1);
            cylinder.setColor(s);
            Console.WriteLine(cylinder.area());
            cylinder.volume();
            Console.WriteLine(cylinder.Color);
        }
    }
}