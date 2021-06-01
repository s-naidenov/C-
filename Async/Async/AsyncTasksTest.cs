using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTasks
{
    class AsyncTasksTest
    {
        public static async Task Start()
        {
            var t = RunTasks();
            Console.WriteLine("Async tasks started");
            await t;
            Console.WriteLine("AsyncTasks ended");
        }
        static async Task RunTasks()
        {
            Console.WriteLine("Tasks started");
            Thread.Sleep(2000);
            var r1 = await Task.Run(() => DoWork(5));
            Console.WriteLine("r1 is ready");
            Thread.Sleep(1000);
            var r2 = await Task.Run(() => DoWork(r1));
            Console.WriteLine("r2 is ready");
            Thread.Sleep(2000);
            Console.WriteLine($"r1 = {r1}, r2= {r2}");
        }

        static int DoWork(int arg)
        {
            Thread.Sleep(3000);
            return ++arg;
        
        }

    }
}
