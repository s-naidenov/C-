using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasks
{
    class Task_6_57
    {
        public static void Run()
        {
            try
            {
                var array = new int[] { 1, 2 };
                Console.Write(array[5]);
            }
            catch (ApplicationException e)
            {
                Console.Write(1);
            }
            catch (SystemException e)
            {
                Console.Write(2);
            }
            catch (Exception e)
            {
                Console.Write(3);
            }
            Console.ReadLine();

        }
    }
}
