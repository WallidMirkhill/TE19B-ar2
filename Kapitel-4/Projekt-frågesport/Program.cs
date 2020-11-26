/* 
Användaren börjar med ange sitt namn.
För varje fråga ska användaren få välja mellan tre olika alternativ.
Tips: det blir mycket enklare om hen får skriva in ”a, b eller c” eller ”1, 2 eller 3” snarare än kompletta svar.
Spelet ska hålla reda på antalet rätta svar, i en int-variabel.
Använd en loop för att se till så användaren inte kan svara något annat än de förutbestämda svaren.
Använd en annan loop för att få spelet att börja om när man spelat klart.
Lägg in en fråga – ”Namn, vill du spela igen?”
I slutet ska användaren få veta sitt resultat.
Antalet poäng man fått avgör vilken text man får i slutet.
*/

using System;

namespace Projekt_frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programmet hälsar på läsaren
            Console.WriteLine("Hejsan! Vad heter du?");

            // Läsaren säger sitt namn
            string namn = string.Parse(Console.ReadLine());


        }
    }
}
