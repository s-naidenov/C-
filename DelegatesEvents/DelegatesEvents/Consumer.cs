using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    internal class Consumer
    {

        protected int Id { get; }
        public static string Type { get; } = "Base Consumer";

        public Consumer(int id) 
        {
            this.Id = id;
        }

        public virtual void GetProduct(string name, int count)
        {
            Console.WriteLine($"Got {name} count: {count}");
        }
        public virtual void Done(string name)
        {
            Console.WriteLine($"Base the end: {name}");
        }
    }
}
