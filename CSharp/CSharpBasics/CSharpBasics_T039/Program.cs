using System;

namespace CSharpBasics_T039
{
    internal class Program
    {
        public delegate void PrintDelegate();
        public delegate int GetDelegate();
        public delegate void OutDelegate(out int number);

        static void Main(string[] args)
        {
            // Method 1 For multicast delegate
            PrintDelegate p1, p2, p3, p4;
            p1 = new PrintDelegate(Print1);
            p2 = new PrintDelegate(Print2);
            p3 = new PrintDelegate(Print3);

            p4 = p1 + p2 + p3 - p2;
            p4();

            // Method 2 For multicast delegate
            PrintDelegate p5;
            p5 = new PrintDelegate(Print1);
            p5 += Print2;
            p5 += Print3;
            p5();

            // Case
            GetDelegate getDelegate = new GetDelegate(Get1);
            getDelegate += Get2;
            getDelegate += Get3;
            int result = getDelegate();
            // It will return only last member of invocation list
            Console.WriteLine("Result =" + result);

            // Case
            OutDelegate outDelegate = new OutDelegate(Out1);
            outDelegate += Out2;
            outDelegate += Out3;
            int outResult;
            outDelegate(out outResult);
            // It will return only last member of invocation list
            Console.WriteLine("Out Result =" + outResult);
        }

        public static void Print1() 
        {
            Console.WriteLine("Hello World 1");
        }
        public static void Print2()
        {
            Console.WriteLine("Hello World 2");
        }
        public static void Print3()
        {
            Console.WriteLine("Hello World 3");
        }

        public static int Get1()
        {
            return 1;
        }
        public static int Get2()
        {
            return 2;
        }
        public static int Get3()
        {
            return 3;
        }

        public static void Out1(out int number)
        {
            number = 1;
        }
        public static void Out2(out int number)
        {
            number = 2;
        }
        public static void Out3(out int number)
        {
            number = 3;
        }
    }
}
