using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndScopes
{
    class SecondInheritor : BaseClassInheritorFromAnotherAssembly
    {
        public SecondInheritor(int id, string privateString) : base(id, privateString)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Second Inheritor:");
            Console.WriteLine($"\tSecond Inheritor-> Public int {this.PublicInt}");
            Console.WriteLine($"\tSecond Inheritor-> ProtectedInt {this.ProtectedFieldOfBaseClassInheritorFromAnotherAssembly}");
            Console.WriteLine($"\tSecond Inheritor-> Protected Double {this.ProtectedDouble}");
            Console.WriteLine($"\tSecond Inheritor-> Protected Internal Int {this.ProtectedInternalInt}");
            Console.ResetColor();
        }


    }
}
