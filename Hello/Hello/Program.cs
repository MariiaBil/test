// See https://aka.ms/new-console-template for more information
using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name:");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.ReadKey();

            Console.Write("Zahl 1:");
            var Zahl1 = Console.ReadLine();
            int Zahl11 = Convert.ToInt32(Zahl1);

            Console.Write("Zahl 2:");
            var Zahl2 = Console.ReadLine();
            int Zahl22 = Convert.ToInt32(Zahl2);

            int AUGEN = Convert.ToInt32(Zahl2);

            if (Zahl11 == 5 || Zahl11 == 10)
                Console.WriteLine(Zahl11);
            else
            Console.WriteLine("Неизвестное число");

            Console.ReadKey();
        }
    }
}