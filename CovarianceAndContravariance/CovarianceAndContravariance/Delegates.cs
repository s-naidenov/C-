using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    class Delegates
    {
        internal delegate T Factory<out T>(string name);
        internal delegate void ShowInfo<in T>(T arg);

        internal static Person CreatePerson(string name)
        {

            return new Person(name);
        }
        internal static Client CreateClient(string name)
        {
            return new Client(name);
        }
        internal static CoolerClient CreateCoolerClient(string name)
        {
            return new CoolerClient(name);
        }

        internal static void ShowPersonName(Person person)
        {
            person.Display();
        }
        internal static void ShowClientName(Client client)
        {
            client.Display();
        }
        internal static void ShowCoolerClientName(CoolerClient client)
        {
            client.Display();
        }






    }

    internal class Person
    {
        public string Name { get; set; }
        public virtual void Display() => Console.WriteLine($"Person name: {Name}");

        public Person(string name)
        {
            this.Name = name;
        }
    }

    internal class Client : Person
    {
        public override void Display()
        {
            Console.WriteLine($"Client name: {Name}");
        }

        public Client(string name) : base(name)
        { 
            
        }
    }

    internal class CoolerClient : Client
    {
        public override void Display()
        {
            Console.WriteLine($"Cooler Client name: {Name}");
        }

        public CoolerClient(string name) : base(name)
        {

        }
    }
}
