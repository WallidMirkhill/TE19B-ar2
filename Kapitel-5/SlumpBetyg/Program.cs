using System;

namespace SlumpBetyg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Slumpa fram ett betyg: F, E, D, C, B, A
            // Slumpa fram ett tal: 0-5
            Random tärning = new Random();
            int slumpTal = tärning.Next(0, 6);

            // Skriv ut slumptalet
            Console.WriteLine($"Slumptalet {slumpTal}");

            // Skriv ut betyg
            /*if (slumpTal == 1)
            {
                System.Console.WriteLine("Du har fått betyget: F");
            }
            if (slumpTal == 2)
            {
                System.Console.WriteLine("Du har fått betyget: E");
            }
            if (slumpTal == 3)
            {
                System.Console.WriteLine("Du har fått betyget: D");
            }
            if (slumpTal == 4)
            {
                System.Console.WriteLine("Du har fått betyget: C");
            }
            if (slumpTal == 5)
            {
                System.Console.WriteLine("Du har fått betyget: B");
            }
            if (slumpTal == 6)
            {
                System.Console.WriteLine("Du har fått betyget: A");
            }*/
            
            // Lösning 2
            /* switch (slumpTal)
            {
                
                case 1:
                Console.WriteLine("Du har fått betyget: F");
                break;

                case 2:
                Console.WriteLine("Du har fått betyget: E");
                break;

                case 3:
                Console.WriteLine("Du har fått betyget: D");
                break;

                case 4:
                Console.WriteLine("Du har fått betyget: C");
                break;

                case 5:
                Console.WriteLine("Du har fått betyget: B");
                break;

                case 6:
                Console.WriteLine("Du har fått betyget: A");
                break; 
            } */

            // Lösning 3
            string[] betyg = {"F", "E", "D", "C", "B", "A"};

            // Skriv index = 1
            // Console.WriteLine(betyg[1]);

            // Skriv ut slumpat betyg
            Console.WriteLine($"Ditt betyg är {betyg[slumpTal]}");
        }
    }
}
