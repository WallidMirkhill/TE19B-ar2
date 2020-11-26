using System;

namespace Uppgift_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fråga användaren hur många sporter hen vill skriva in
            Console.WriteLine("Hur många sporter vill du skriva in?");
            int antal = int.Parse(Console.ReadLine());
            string[] sporter = new string[antal];
            
            // Därefter ska sporterna skrivas in, en efter en, på var sin rad
             for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("Skriv in en sport");
                sporter[i] = Console.ReadLine();
            }

            // Slutligen ska programmet skrivas utan namnet på alla sporterna
            Console.WriteLine("Här är de sporter du skrev in");
            for (int i = 0; i < antal; i++)
            
            {
                Console.WriteLine(sporter[i]);
            }
        }
    }
}
