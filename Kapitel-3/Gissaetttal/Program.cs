using System;

namespace Gissaetttal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Slumpa fram ett tal
            Random random = new Random();
            int slumptal = random.Next(1, 7);

            // Fråga fem gånger 
            for (int i = 0; i < 5; i++) // i++ = i + 1
            {
                // Läsa in en gissning
                Console.Write("Gissa ett tal (1-6)?");
                int gissning = int.Parse(Console.ReadLine());

                // Kolla om gissningen är korrekt 
                if (gissning == slumptal)
                {
                    Console.WriteLine("Rätt svar!");
                    i = 5; // Knep
                }
                else
                {
                    Console.WriteLine("Fel svar!");
                }

            }
        }
    }
}
