using SecondAssembly;
using System;

namespace InheritanceAndScopes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new BaseClassInheritorFromAnotherAssembly(6);
            Console.WriteLine();
            var baze = new Based();
            Console.WriteLine();
            var BaseClassInternalInheritor = new BaseClassInternalInheritor();
            Console.WriteLine();
            var second = new SecondInheritor(6, "Second Inheritor");
        }
    }
}
