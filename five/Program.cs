using System;
namespace HelloWorldOne
{
    public class Rect
    {
        public double width;
        public double height;
        public Rect(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public Rect( )
        {
            width = 10;
            height = 10;
        }
        public double area()
        {
            return width * height;
        }
        public double perimeter()
        {
            return (width + height) * 2;
        }
    }
    public class PlainRect : Rect
    {
        public double startX;
        public double startY;
        public PlainRect(double width, double height, double startX, double startY)
        {
            this.width = width;
            this.height = height;
            this.startX = startX;
            this.startY = startY;
        }
        public PlainRect( )
        {
            this.width = 0;
            this.height = 0;
            this.startX = 0;
            this.startY = 0;
        }
        public bool isInside(double x, double y)
        {
            if(x>=startX&&x<=startX + width)
            {
                if(y>=startY&&y<=startY + height)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class HelloWorld
    {


        static void Main(string[] args)
        {
            PlainRect plainRect = new PlainRect(20,10,10,10);

            Console.WriteLine(plainRect.isInside(25.5, 13));
        }
    }
}