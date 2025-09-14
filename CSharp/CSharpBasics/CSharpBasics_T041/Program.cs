using System;
using System.IO;

namespace CSharpBasics_T041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter 2 numbers for division:");
                    string[] strInts = Console.ReadLine().Split(' ');

                    int result = Convert.ToInt32(strInts[0]) / Convert.ToInt32(strInts[1]);
                    Console.WriteLine("Result : {0}", result);
                }
                catch (Exception ex)
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter("C:\\GitHub_SK_Repo\\DSA\\CSharp\\CSharpBasics\\CSharpBasics_T041x\\Log.txt");
                        sw.WriteLine(ex.GetType().Name);
                        sw.WriteLine(ex.Message);
                        sw.WriteLine(ex.StackTrace);
                        sw.WriteLine("-----------------------");
                        sw.Close();
                        Console.WriteLine("Error Occured. Try again");
                    }
                    catch (Exception ey)
                    {
                        throw new Exception(ey.ToString(), ex);
                    }
                }
            }
            catch (Exception ez)
            {
                Console.WriteLine(ez.GetType().Name);
                Console.WriteLine(ez.InnerException?.GetType().Name);
            }
        }
    }
}
