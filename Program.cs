namespace MultiThreadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Modern way to write multi threading programs
            Task.Run(() => {
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Task 1");
                }
            });
            Task.Run(() => Function2());
            Task.WaitAll(Task.Delay(1000));
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
