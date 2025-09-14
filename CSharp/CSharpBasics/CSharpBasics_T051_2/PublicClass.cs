using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T051_2
{
    public class PublicClass
    {
        public PublicClass() {
            //Within assemby can be accessed as it's internal
            InternalClass internalClass = new InternalClass();
        }
    }
}
