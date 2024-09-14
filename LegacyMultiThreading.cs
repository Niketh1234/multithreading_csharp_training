using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingApp
{
    internal class LegacyMultiThreading
    {
        static void Main(string[] args)
        {
            /* Legacy Multi threading program*/
            Thread t1 = new Thread(Function1);
            Thread t2 = new Thread(Function2);
            t1.Start();
            t2.Start();
            
        }
        static void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1");
            }
        }
        static void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 executed");
                Thread.Sleep(1000);
            }
        }
    }
}
