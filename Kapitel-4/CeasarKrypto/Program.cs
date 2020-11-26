using System;

namespace CeasarKrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ange en text
            Console.Write("Ange en text: ");
            string text = Console.ReadLine();

            // Loopa igen inmattad text bokstav för bokstav
            int textlängd = text.Length;
            Console.WriteLine($"Texten är {textlängd} tecken lång");

            // Be om användaren om nyckel
            Console.Write("Skriv ett tal mellan (1-9): ");
            string nyckelString = Console.ReadLine();

            // Säkerställa att vi får in ett tal
            int nyckel = 0;
            while (!int.TryParse(nyckelString, out nyckel))
            {
                Console.Write("Du måste mata in ett ta! Ange ett tal (1-9): ");
                nyckelString = Console.ReadLine();
            }

            // Loopa igenom för bokstav
            string krypteradText = "";
            for (int i = 0; i < textlängd; i++)
            {
                // Console.WriteLine($"Loop nr {i}");

                // Plocka ut bokstav på position i 
                char bokstav = text[i];
                Console.WriteLine($"Bokstaven på position {i} är {bokstav}");

                // ASCII-värdet för ett tecken
                int ASCII = (int)bokstav;
                Console.WriteLine($"Bokstaven {bokstav} har ASCII-värdet {ASCII}");

                // Ceasar kryptering 
                ASCII += nyckel;

                // Plocka ut motsvarande tecken enligt ASCII-tabellen 
                char krypteradBokstav = (char)ASCII;
                Console.WriteLine($"Bokstaven {bokstav} krypteras till {krypteradBokstav}");

                // Samla ihop bokstäverna 
                krypteradText += krypteradBokstav.ToString();
            }

            // Skriv ut krypterade texten 
            Console.WriteLine($"Det krypterade meddelandet är: {krypteradText} ");
        }
    }
}
