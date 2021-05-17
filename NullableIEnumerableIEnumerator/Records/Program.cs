using System;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Tom", 34);
            Person p1 = new Person("Tom", 34);
            Person p2 = new Person("Alex", 42);
            Console.WriteLine($"p == p1 {p == p1}");
            Console.WriteLine($"p1 != p2 {p1 != p2}");

            //p.Age = 32; error 

            Person p3 = p2 with { Name = "Flora" };
            Console.WriteLine($"p3.Age == p2.Age {p3.Age == p2.Age}");

            Client p4 = new Client() { Name = "Frost", Age = 25, Email = "frost@mail.com" };
            var (name, age) = p3;
            Console.WriteLine($"{name} : {age}");

            var (clName, clAge, email) = p4;

            Console.WriteLine($"{clName} : {clAge} : {email}");

        }
    }

    public record Person(string Name, int Age);

    public record Client
    {
        public string Name { get; init; }
        public int Age { get; init; }
        public string Email { get; init; }

        public void Deconstruct(out string name, out int age, out string email) => (name, age, email) = (Name, Age, Email); 
    }
}
