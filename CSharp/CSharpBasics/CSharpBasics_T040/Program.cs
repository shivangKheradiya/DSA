using System;
using System.IO;

namespace CSharpBasics_T040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("C:\\GitHub_SK_Repo\\DSA\\CSharp\\CSharpBasics\\CSharpBasics_T040\\DataTextFile.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            /*
             * catch (Exception ex) is base class so, 1st initialization is not allowed 
             */
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.FileName + ": File is Not available.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("---------------");
                Console.WriteLine(ex.StackTrace);
            }
            // Actually finally block is not required
            finally {
                Console.WriteLine("All Done");
                if (sr != null) sr.Close();
            }
        }
    }
}
