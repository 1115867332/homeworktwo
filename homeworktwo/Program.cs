using System;
namespace HelloWorldOne
{
    public class Cfx
    {
        int chang;
        int kuan;

        public int Chang { get => chang; set => chang = value; }
        public int Kuan { get => kuan; set => kuan = value; }
        public int c()
        {
            return (chang + kuan) * 2;
        }
        public int s()
        {
            return chang * kuan;
        }
    }
    class HelloWorld

    {

        static void Main(string[] args)
        {
            int c1, k1;
            c1 =  Convert.ToInt32(Console.ReadLine());
            k1 = Convert.ToInt32(Console.ReadLine());
            Cfx  cfx = new Cfx();
            cfx.Chang = c1;
            cfx.Kuan = k1;
            Console.WriteLine(cfx.c());
            Console.WriteLine(cfx.s());
        }
    }

}

