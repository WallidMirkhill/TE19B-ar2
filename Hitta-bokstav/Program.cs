using System;

namespace Hitta_bokstav
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ange en bokstav
            Console.Write("Ange en bokstav: ");
            string bokstav = Console.ReadLine().ToUpper();
           
            // För säkerhetsskull omvandla till versaler
            // bokstav = bokstav.ToUpper();

            // Skapa en samling för alfabetet (string)
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

            // Hitta bokstavens plats i alfabetet
            int index = alfabetet.IndexOf(bokstav);

            // Vart fanns bokstaven
            Console.WriteLine($"{bokstav} finns på position {index}");

            // Skapa en samling för morsekod (array)
            string[] morse = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " "};

            Console.WriteLine($"{morse[0]} {morse[20]}");

            // Skriv ut morsekoden för bokstaven 
            string morseBokstav = morse[index];
            Console.WriteLine($"{bokstav}'s morsekod är {morseBokstav}");
        }
    }
}
