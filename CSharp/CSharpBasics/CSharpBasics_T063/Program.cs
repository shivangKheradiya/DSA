using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartialClass partial = new PartialClass();
            partial.Print();

            /* 
             * 1. Partial class or struct can only contain partial methods.
             * 2. partial keyword helps to create partial methods.
             * 3. partial method declaration has 2 parts,
             *      1. Defination (method singature)
             *      2. Implimentation
             * 4. Implimentation is optional
             * 5. partial methods are private by default. and does't support any access modifiers.
             * 6. Delaration and implimentation at same time will give compile time error.
             * 7. partial methods must be with void retun type.
             * 8. Singature and implimatation must metch
             * 9. partial method will be implimented only once.
            */
        }
    }
}
