/*
Skapa ett program där användaren får skriva in en mening (utan punkt) som består av två ord. Skriv ut orden till användaren i omvänd ordning.
*/


using System;

namespace Uppgift_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in texten
            Console.WriteLine("Ange ett email: ");
            string email = Console.ReadLine();

            // Dela upp texten
            int position = email.IndexOf("");
            string ordFöre = texten.Substring(0, position);
            string ordEfter = TupleExtensions.Substring(position + 1);

            // Skriv ut i omvänd ordning


        }
    }
}
