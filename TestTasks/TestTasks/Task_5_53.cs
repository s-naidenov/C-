using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasks
{
    class Task_5_53
    {
        private enum En
        {
            First = 15,
            Second,
            Third = 54
        }

        public static void Run()
        {
            Console.WriteLine((int)En.Second);
        }
    }
}
