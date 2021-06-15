using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasks
{
    class Task_2_6
    {
        private static Object syncObject = new Object();
        private static void Write()
        {
            lock (syncObject)
            {
                Console.WriteLine("test");
            }
        }

        public static void Run()
        {
            lock (syncObject)
            {
                Write();
            }

        }



    }
}
