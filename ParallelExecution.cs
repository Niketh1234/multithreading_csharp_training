using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingApp
{
    internal class ParallelExecution
    {
        static void Main(string[] args)
        {
            // TPL : Task Parallel Library
            // HotSpot : It is a part of a program where CPU usage is peaked.
            Parallel.ForEach([1, 2, 3, 4], i => { Console.WriteLine(i); });
            Parallel.For(1, 10, (i) => { Console.WriteLine(i); });

            int sum = 0;
            Parallel.Invoke(() => {
                Parallel.For(1, 11, (i) => { 
                    Console.WriteLine("Function 1 in parallel invoke");
                    sum += i;
                });
            }, () => {
                for(int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Function 2 in parallel invoke");
                }
            }, Function3);
            Console.WriteLine(sum);


        }
        static void Function3()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 3 in parallel invoke");
            }
        }
    }
}
