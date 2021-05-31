using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    public class TasksMain
    {
        private static int _counter = 0;
        private static Mutex _mutex = new Mutex();

        static public void Main(string[] args)
        {
            RunWork(10);
            Console.WriteLine("Main finished");
        }

        static void RunWork(int taskNumber)
        {
            List<Task> tasks = new List<Task>(taskNumber);
            for (int i = 0; i < taskNumber; i++)
            {
                Task<int> parent = new Task<int>(IncreaseCounter);
                Task child = parent.ContinueWith(PrintCounter);
                parent.Start();
                tasks.Add(child);
            }
            Task.WaitAll(tasks.ToArray());
        }

        static int IncreaseCounter()
        {
            int res;
            _mutex.WaitOne();
            res = ++_counter;
            _mutex.ReleaseMutex();
            var inner = Task.Factory.StartNew(Sleep, TaskCreationOptions.AttachedToParent);
            return res;
        }

        static private void Sleep()
        {
            Console.WriteLine($"Task {Task.CurrentId} is sleeping");
            Thread.Sleep(1000);
        }

        static void PrintCounter(Task<int> task)
        {

            Console.WriteLine($"Current task id: {Task.CurrentId} | parent task id: {task.Id} result {task.Result}");

        }

    }
}
