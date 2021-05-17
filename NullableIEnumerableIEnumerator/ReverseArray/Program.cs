using System;
using ReversedList;
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            ReversedList<int> list = new ReversedList<int>();
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }

        }
    }
}
