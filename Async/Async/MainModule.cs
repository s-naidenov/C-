using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class MainModule
    {
        public static async Task Main(string[] args)
        {
            await AsyncTask.AsyncTaskTest.Start();
            Console.WriteLine("######################");
            await AsyncTasks.AsyncTasksTest.Start();
            Console.WriteLine("######################");
            await AsyncParallelTasks.AsyncParallelTasksTest.Start();


            

        }

    }
}
