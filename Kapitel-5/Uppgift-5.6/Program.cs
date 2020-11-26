using System;

namespace Uppgift_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren att skriva in 5 städer
            Console.WriteLine("Skriv in 5 städer: ");
            string[] städer = new string[5];
            

            for (int i = 0; i < städer.Length; i++)
            {
                Console.WriteLine($"Skriv in stad {i+1}");
                städer[i] = Console.ReadLine();
            }
        }
    }
}
