using System;
using ReversedList;
namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            ReversedList<int?> list = new ReversedList<int?>();
            list.Add(null);
            list.Add(1);
            list.Add(2);
            list.Add(null);
            list.Add(3);
            list.Add(4);
            foreach (int? e in list)
            {
                if (e.HasValue)
                {
                    Console.WriteLine(e.Value);
                }
                else
                {
                    Console.WriteLine("null"); 
                }
                
            }

        }
    }
}
