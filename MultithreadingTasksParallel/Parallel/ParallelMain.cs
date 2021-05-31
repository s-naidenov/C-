using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace pParallel
{
    public class ParallelMain
    {
        static int counter = 0;
        static object mut = new object();
        public static void Main(string[] args)
        {
            ParallelLoopResult forResult = Parallel.For(1, 100, Func);
            if (!forResult.IsCompleted)
            {
                Console.WriteLine($"For ended {forResult.LowestBreakIteration} counter = {counter}");
            }
            List<int> arguments = new List<int>();
            for (int i = 1000000; i > 0; i--)
            {
                if (i == 300000)
                {
                    arguments.Add(5);
                }
                arguments.Add(0 - i);

            }
            counter = 0;
            ParallelLoopResult forEachResult = Parallel.ForEach(arguments, DoubleInt);
            if (!forEachResult.IsCompleted)
            {
                Console.WriteLine($"Foreach ended {forResult.LowestBreakIteration} counter = {counter}");
            }
        }

        static void Func(int x, ParallelLoopState pls)
        {
            //Console.WriteLine($"Task {Task.CurrentId} x = {x}");
            lock (mut)
            {
                counter++;
            }
            if (x == 50)
            {
                pls.Break();
            }
        }
        static void DoubleInt(int x, ParallelLoopState pls)
        {
            //Console.WriteLine($"Task {Task.CurrentId} x = {x*2}");
            lock (mut)
            {
                counter++;
            }
            if (x * 2 == 10)
            {
                pls.Break();
            }
        }
    }
}
