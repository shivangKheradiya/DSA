using System;

namespace CSharpBasics_T036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyFnc HelloWorld = new MyFnc(Program.Print);

            HelloWorld("Hello World");
        }

        // Type Safe Function pointer. E.g. It's always check signature/ type of function
        public delegate void MyFnc(string str);

        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
