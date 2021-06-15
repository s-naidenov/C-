using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasks
{
    class Tests
    {

        public static void Run()
        {
            int n1 = 2;
            int n2 = 5;
            int result = n2 * 3 + 20 / 2 * n1--;
            Console.WriteLine(result);

            int num1 = 4;
            int num2 = 5;
            int num3 = 15;
            int num4 = 10;
            int num5 = 5;
            result = 12;

            result += num1 * num2 + num3 % num4 / num5;
            Console.WriteLine(result);
            int x = 8;
            int y = 9;
            result = x++ + ++y;
            Console.WriteLine(result);

            int i = 0;
            Console.Write(i++ + Calculate(i));
            Console.WriteLine(i);




            Person tom = new Person();
            tom.Age = 25;
            Console.WriteLine(tom.Age);

            double dx = 50.5d;
            double dy = 10d;

            Console.WriteLine(dx.Equals(dy));

        }
        public static int Calculate(int i)
        {
            Console.Write(i++);
            return i;
        }

        class Person
        {
            private int age = 15;

            public int Age
            {
                get { return age; }
                set { }
            }
        }


        class Counter
        {

            public int Number { get; set; }

            // определение оператора сложения
        }
        class AAuto
        {
            public virtual void Display()
            {
                Console.WriteLine("Auto");
            }
        }

        class Auto : AAuto
        {
            public override sealed void Display()
            {
                Console.WriteLine("Auto");
            }
        }
        class Truck : Auto
        {
            public void DisplayInfo()
            {
                base.Display();
            }
        }


        public class StringGetter<T>
        {
            public string GetString(T item) => item.ToString();
        }

    }
}
