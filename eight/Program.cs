using System;

namespace HelloWorldOne
{
    interface interfaceA
    {
        public void printCapitalLetter();
    }
    interface interfaceB
    {
        public void printLowercaseLetter();
    }
    public class Print : interfaceA, interfaceB
    {
        public void printCapitalLetter()
        {
            for(int i = 0; i < 26; i++)
            {
                Console.Write(Convert.ToChar('A'+i));
            }
            Console.WriteLine();
        }
        public void printLowercaseLetter()
        {
            for (int i = 0; i < 26; i++)
            {
                Console.Write(Convert.ToChar('a' + i));
            }
        }
    }
    class HelloWorld

    {


        static void Main(string[] args)
        {
            interfaceA a = new Print();
            a.printCapitalLetter();
            interfaceB b  = new Print();
           
            b.printLowercaseLetter();

        }
    }
}