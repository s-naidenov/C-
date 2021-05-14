using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 7;
            Console.WriteLine("Before RefFunc");
            Console.WriteLine($"x = {x} | y = {y}");
            RefFunc<int>(ref x, ref y);
            Console.WriteLine("After RefFunc");
            Console.WriteLine($"x = {x} | y = {y}");
            
            Console.WriteLine("#");

            Console.WriteLine("Before OutFunc");
            Console.WriteLine($"x = {x} | y = {y}");
            OutFunc(x, out y);
            Console.WriteLine("After OutFunc");
            Console.WriteLine($"x = {x} | y = {y}");
            
            Console.WriteLine("#");
            
            A a = new A();
            a.X = 100;
            a.Y = 200;
            Console.WriteLine($"Befor AFunc x = {a.X} | y = {a.Y}");
            AFunc(a);
            Console.WriteLine($"After AFunc x = {a.X} | y = {a.Y}");
            Console.WriteLine("#");

            Console.WriteLine($"Befor NewA x = {a.X} | y = {a.Y}");
            NewA(a);
            Console.WriteLine($"After NewA x = {a.X} | y = {a.Y}");
            
            Console.WriteLine("#");
            
            Console.WriteLine($"Befor NewRef x = {a.X} | y = {a.Y}");
            NewRef(ref a);
            Console.WriteLine($"After NewRef x = {a.X} | y = {a.Y}");

        }


        static void RefFunc<T>(ref T x, ref T y)
        {
            T tmp = x;
            x = y;
            y = tmp;
        }


        static void OutFunc(int x, out int y)
        {
            y = x;
        }


        static void AFunc(A x) 
        {
            x.X += 10;
            x.Y += 10;
        }

        static void NewA(A x)
        {
            x = new A();
        }

        static void NewRef(ref A x)
        {
            x = new A();
        }





    }
}
