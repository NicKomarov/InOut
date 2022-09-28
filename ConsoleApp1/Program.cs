using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(s);
                Console.WriteLine($"Ви ввели число {n}");
            }
            catch
            {
                Console.WriteLine("Не коректне введення");
            }
        }
    }
}
