using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingApp
{
    internal class TaskDemo
    {
        static async Task Main(string[] args)
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Function1 executed");
                }   
            });
            await Task.Run(() => Function2());
            Task.WaitAll(Task.Delay(1000));
        }
        static async  void Function2()
        {
            for (int i = 0; i < 10; i++) { 
                Console.WriteLine("Function2 executed");
                Thread.Sleep(1000);
            }
        }
    }
}
