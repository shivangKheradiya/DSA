using System;

namespace CSharpBasics_T043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 2 numbers for division:");
                string[] strInts = Console.ReadLine().Split(' ');

                int result = Convert.ToInt32(strInts[0]) / Convert.ToInt32(strInts[1]);
                Console.WriteLine("Result : {0}", result);
            }
            catch (FormatException ea) { Console.WriteLine("Please Resolve FormatException:" + ea.Message); }
            catch (OverflowException eb) { Console.WriteLine("Please Resolve OverflowException:" + eb.Message); }
            catch (DivideByZeroException ec) { Console.WriteLine("Please Resolve DivideByZeroException:" + ec.Message); }
            catch (Exception ex) { Console.WriteLine("Please Resolve FormatException:" + ex.Message); }
        }
    }
}
