using System;
using System.Collections.Generic;

namespace DelegatesEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Consumer baseConsumer = new Consumer(656);
            CoolerConsumer сoolerConsumer = new CoolerConsumer(999, "cooler");

            List<Consumer> consumers = new List<Consumer>();
            Producer factory = new Producer();
            consumers.Add(baseConsumer);
            consumers.Add(сoolerConsumer);
            foreach (var c in consumers)
            {
                factory.ProductHandler += c.GetProduct;
                factory.Done += c.Done;
            
            }
            factory.Produce();
            Console.WriteLine("THE END");
        }
    }
}
