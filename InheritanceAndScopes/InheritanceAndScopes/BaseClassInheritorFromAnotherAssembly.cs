using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndScopes
{
    internal class BaseClassInheritorFromAnotherAssembly : SecondAssembly.Based
    {
        protected int ProtectedFieldOfBaseClassInheritorFromAnotherAssembly { get; set; }
        public BaseClassInheritorFromAnotherAssembly(int id, string privateString = "Default BaseClassInheritorFromAnotherAssembly") : base(privateString)
        {
            this.PublicInt = id;
            Console.WriteLine("Base Class Inheritor From Another Assembly:");
            Console.WriteLine($"\tInheritor From Another Assembly-> Public int {this.PublicInt}");
            Console.WriteLine($"\tInheritor From Another Assembly-> Protected Double {this.ProtectedDouble}");
            Console.WriteLine($"\tInheritor From Another Assembly-> Protected Internal Int {this.ProtectedInternalInt}");
        }

    }
}
