using System;

namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] städer = new string[3];
            
            Console.WriteLine("Skriv in en svensk stad förutom städer[0] och städer[1]: ");
            
            städer[0] = "Stockholm";
            städer[1] = "Göteborg";
            städer[2] = Console.ReadLine();
        }
    }
}
