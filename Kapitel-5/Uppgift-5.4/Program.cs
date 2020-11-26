using System;

namespace Uppgift_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en array med minst 5 årtal 
            int[] årtal = {1914, 1920, 1945, 1970, 1990, 1995};

            // Fråga användaren om ett årtal att söka 
            Console.Write("Ange ett sökårtal: ");
            int gissning = int.Parse(Console.ReadLine());

            // Skapa en flagga 
            bool flagga = false;

            // Loopa igenom arrayen årtal
            for (int i = 0; i < årtal.Length; i++)
            {
                // Skriv ut alla index om årtalet hittas i arrayen
                if (årtal[i] == gissning)
                {
                    Console.WriteLine($"Hittat {gissning} på index {i}");
                    flagga = true;
                }
            }
            
            // Om årtalet inte fanns på någon plats ska programmet skriva "Årtalet kunde inte hittas"
            if (!flagga)     // Samma om flagga == false
            {
                Console.WriteLine("Årtalet kunde inte hittas");
            }
        }
    }
}
