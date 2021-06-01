using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncParallelTasks
{
    class AsyncParallelTasksTest
    {

        public static async Task Start()
        {
            Console.WriteLine("Enter number of tasks");
            var input = Console.ReadLine();
            int n = 2;
            try
            {
                n = Int32.Parse(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"Finally block, n = {n}");
            }
            Console.WriteLine("Async Parallel Tasks started");
            var t = RunTasks(n);
            Console.WriteLine("After tasks");
            await t;
            Console.WriteLine("Async Parallel Tasks ended");
        }

        private static async Task RunTasks(int num)
        {
            List<Task<int>> tasks = new List<Task<int>>(num);
            for (int i = 0; i < num; i++)
            {
                var t = new Task<int>(() => DoWork(i));
                t.Start();
                tasks.Add(t);
                Thread.Sleep(200);
            }
            Console.WriteLine("All tasks ran");
            var res = await Task.WhenAll(tasks.ToArray());
            string str = String.Join(", ", res);
            Console.WriteLine(str);

        }

        private static int DoWork(int x)
        {
            Thread.Sleep(4000);
            x += 10;
            return x;
        }

    }
}
