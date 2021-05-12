using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    class Producer
    {
        private event Action<string> _doneHandler;
        public event Action<string> Done
        {
            add
            {
                _doneHandler += value;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"done handler added {value.Method.Name}");
                Console.ResetColor();
            }
            remove
            {
                _doneHandler -= value;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"done handler removed {value.Method.Name}");
                Console.ResetColor();



            }


        }
        private event Action<string, int> _productHandler;
        public event Action<string, int> ProductHandler
        {
            add
            {
                _productHandler += value;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Prod handler added {value.Method.Name}");
                Console.ResetColor();

            }
            remove
            {
                _productHandler -= value;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Prod handler removed {value.Method.Name}");
                Console.ResetColor();

            }

        }


        public void Produce()
        {
            for (int i = 0; i < 20; i++)
            {
                _productHandler?.Invoke($"new Product {i}", i + 10);
            }
            _doneHandler?.Invoke("Done");
        }





    }
}
