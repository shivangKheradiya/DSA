using System;

namespace CSharpBasics_T050_1
{
    internal class MyCustomer : Customer
    {
        public int GetId()
        {
            return base.PID;
        }
    }
}
