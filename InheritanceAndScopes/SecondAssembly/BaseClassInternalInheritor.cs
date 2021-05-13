using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssembly
{
    public class BaseClassInternalInheritor : Based
    {
        public BaseClassInternalInheritor(string name = "Default BaseClassInternalInheritor name") : base(name)
        {
            Console.WriteLine("Base Class Internal Inheritor:");
            Console.WriteLine($"\tInternal Inheritor-> Public int {this.PublicInt}");
            Console.WriteLine($"\tInternal Inheritor-> Internall Decimal {this.InternalDecimal}");
            Console.WriteLine($"\tInternal Inheritor-> Private ProtectedInt {this.PrivateProtectedInt}");
            Console.WriteLine($"\tInternal Inheritor-> Protected Double {this.ProtectedDouble}");
            Console.WriteLine($"\tInternal Inheritor-> Protected Internal Int {this.ProtectedInternalInt}");
        }


    }
}
