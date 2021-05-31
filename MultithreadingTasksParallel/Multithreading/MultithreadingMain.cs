using System;
using System.Threading;

namespace Multithreading
{
    public class MultithreadingMain
    {
        static Mutex mut1 = new Mutex();
        static Mutex mut2 = new Mutex();
        public static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main";
            Thread child = new Thread(PrintMessage);
            child.Name = "Child";
            mut1.WaitOne();
            child.Start();
            for (int i = 0; i < 10; i++) {
                mut2.WaitOne();
                mut1.ReleaseMutex();
                Console.WriteLine($"Iteration: {i} | thread {Thread.CurrentThread.Name} time: {System.DateTime.Now}");
                mut2.ReleaseMutex();
                mut1.WaitOne();
            }
            child.Join();
        }


        public static void PrintMessage() 
        {
            for (int i = 0; i < 10; i++)
            {
                mut1.WaitOne();
                mut2.WaitOne();
                Console.WriteLine($"Iteration: {i} | thread {Thread.CurrentThread.Name} time: {System.DateTime.Now}");
                mut1.ReleaseMutex();
                mut2.ReleaseMutex();
            }
        }
    }
}
