using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW($"Mercedes Benz", 60000, 240, "black");
            
            MERCEDES mersedes = new MERCEDES($"BMW M5", 50000, 300, "blue");

            Console.WriteLine(bmw.GetDetails());
            Console.WriteLine(mersedes.GetDetails());

        }
    }
}
