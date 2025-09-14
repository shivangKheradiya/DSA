using System;
using CSharpBasics_T050_1;

namespace CSharpBasics_T050_2
{
    public class YourCustomer : Customer
    {
        // Below method is not possible because it's internal property. So, Different assemby can't access it.
        // public int GetId()
        // {
        //     return base.IID;
        // }

        // It's possible to use the protected internal property. So, different assemby can use.
        public int GetPId()
        {
            return base.PID;
        }
    }
}
