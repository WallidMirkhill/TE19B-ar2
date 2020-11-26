using System;

namespace Lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren att gissa ett tal mellan 1-10
            Console.WriteLine("Gissa vart markören kommer att stanna på (1-10).");
            string svar = Console.ReadLine();
            

            // Slumpa fram ett tal mellan 1-10
            Random slumptal = new Random();
            int slumptal = slumptal.Next(1, 11);

            // Berätta för användaren vilket blev slumptalet


            // Berätta för användaren om man vann eller inte
        }
    }
}
