using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T068
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Optional Parameter
            * 1. Use Parameter Array
            * 2. Method Overloading
            * 3. Specify parameter defaults
            * 4. Use optional attribute that is present in System.Runtime.InteropServices
            */
        }
        
        // 1. Use Parameter Array
        public static int AddNumbers(int firstNum, int secondNum, params int[] restNums ){
            int result = firstNum + secondNum;
            if (!restNums)
            {
                foreach (int item in restNums)
                {
                    result +=item;
                }
            }
            return result;
        }

        // 2. Method Overloading
        public static int AddNumbers(int firstNum, int secondNum){
            return this.AddNumbers(firstNum, secondNum, null);
        }
    }
}