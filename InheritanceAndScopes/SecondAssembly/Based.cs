using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssembly
{
    public class Based
    {
        private string _privateString;
        public int PublicInt { get; set; }
        protected double ProtectedDouble { get; set; }

        internal decimal InternalDecimal { get; private set; }

        protected internal int ProtectedInternalInt { get; set; }
        private protected int PrivateProtectedInt { get; set; }
        public Based(string privateString = "Default Base Name")
        {
            _privateString = privateString;
            this.PublicInt = int.MaxValue;
            this.InternalDecimal = decimal.MaxValue;
            this.ProtectedDouble = double.MaxValue;
            this.ProtectedInternalInt = int.MaxValue;
            this.PrivateProtectedInt = int.MaxValue;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Base Class:");
            Console.WriteLine($"\tBase -> Public int {this.PublicInt}");
            Console.WriteLine($"\tBase -> Private string {this._privateString}");
            Console.WriteLine($"\tBase -> Internall Decimal {this.InternalDecimal}");
            Console.WriteLine($"\tBase -> Private ProtectedInt {this.PrivateProtectedInt}");
            Console.WriteLine($"\tBase -> Protected Double {this.ProtectedDouble}");
            Console.WriteLine($"\tBase -> Protected Internal Int {this.ProtectedInternalInt}");
            Console.ResetColor();
        }


        public virtual void PublicMethod()
        {
            Console.WriteLine($"Based name = {_privateString}");
        }

        protected virtual void ProtectedMethod()
        {
            Console.WriteLine("Protected Method");
        }


    }
}
