/*
Skapa ett program som frågar användaren vilket land som vann fotbolls-VM för damer år 2015. Om användaren svarar USA ska programmet skriva ut att svaret var rätt, annars ska programmet skriva ut att svaret var fel. Det ska inte spela någon roll om användaren skriver svaret med stora eller små bokstäver.
*/

using System;

namespace Uppgift_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in text, (USA)
            Console.Write("Vem vann fotbolls-VM för damer 2015 ? ");
            string vinnare = Console.ReadLine();

            // Sanera inmatningen vinnare
            vinnare = vinnare.ToLower();

            // KOntrollera om rätt svar
        }
    }
}
