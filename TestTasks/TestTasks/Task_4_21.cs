using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasks
{
    class Task_4_21
    {
        public static void Run()
        {
            string str1 = "abs";
            string str2 = "abs";
            string str3 = "0";
            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(str1 == str3);
            Console.WriteLine(String.Compare(str2, str3));
        }
    }
}
