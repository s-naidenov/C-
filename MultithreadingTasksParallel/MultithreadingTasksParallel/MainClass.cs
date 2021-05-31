using System;
using Multithreading;
using pParallel;
using Tasks;
namespace MultithreadingTasksParallel
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###_Tasks_###");
            TasksMain.Main(args);
            Console.WriteLine("\n###_Threads_###");
            MultithreadingMain.Main(args);
            Console.WriteLine("\n###_Parallel_###");
            ParallelMain.Main(args);
            
        }

    }
}
