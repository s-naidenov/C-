using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    internal class CoolerConsumer : Consumer
    {
        public string Name { get; }
        public CoolerConsumer(int id, string name) : base(id)
        {
            this.Name = name;
        }

        public override void GetProduct(string name, int count)
        {
            Console.WriteLine($"CoolerConsumer id: {Id} name: {Name}, got product {name} count {count}");
        }

        public override void Done(string name)
        {
            Console.WriteLine($"CoolerConsumer the end: {name}");
        }

    }
}
