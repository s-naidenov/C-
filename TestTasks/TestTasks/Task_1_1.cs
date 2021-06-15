
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasks
{
    class Task_1_1
    {
        public static void Run()
        {
            try
            {
                B obj1 = new A() as B;
                obj1.Foo();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();
        }

    }


    class A
    {
        public virtual void Foo()
        {
            Console.Write("Class A");
        }
    }
    class B : A
    {
        public override void Foo()
        {
            Console.Write("Class B");
        }
    }
}

