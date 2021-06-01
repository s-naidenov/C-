using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTask
{
    class AsyncTaskTest
    {
        public static async Task Start()
        {
            Console.WriteLine("Async task started");
            var t = FirstWrapperAsync();
            await t;
            Console.WriteLine("AsyncTask ended");
        }


        static async Task FirstWrapperAsync()
        {
            Console.WriteLine("First wrapper start");
            var res = await SecondWrapperAsync();//await Task.Run(()=>IncreaseValue(66,10));//;
            Console.WriteLine("First wrapper ended");
            Console.WriteLine($"Result = {res}");
        }

        static async Task<int> SecondWrapperAsync()
        {
            Console.WriteLine("Second wrapper started");
            var res = await FuncAsync(10);
            Console.WriteLine("Second wrapper ended");
            return res;
        
        }

        static async Task<int> FuncAsync(int x)
        {
            Console.WriteLine("FuncAsync: before await");
            Task<int> task1 = Task.Run(() => IncreaseValue(x,15));
            var res = await task1;
            Console.WriteLine("FuncAsync: after await");
            return res; 
        }



        static int IncreaseValue(int val, int delta)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Increase value method");
            return val += delta;
        }
    }
}
