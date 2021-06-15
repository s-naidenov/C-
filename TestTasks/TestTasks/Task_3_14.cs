using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasks
{
    class Task_3_14
    {

        class MyCustomException : DivideByZeroException
        {

        }
        public static void Run()
        {
            try
            {
                Calc();
            }
            catch (MyCustomException e)
            {
                Console.WriteLine("Catch MyCustomException");
                throw;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Catch Exception");
            }
            Console.ReadLine();

        }

        private static void Calc()
        {
            int result = 0;
            var x = 5;
            int y = 0;
            try
            {
                result = x / y;
            }
            catch (MyCustomException e)
            {
                Console.WriteLine("Catch DivideByZeroException");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Catch Exception");
            }
            finally
            {
                throw new MyCustomException();
            }
        }
    }
}
