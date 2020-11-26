using System;

namespace Uppgift_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en array med minst 5 heltal
            int[] talLista = {5, 89, 787, 9797, 97487};

            // Beräkna summan av alla heltal i arrayen med hjälp av en foreach-loop
            int summa = 0;
            foreach (var tal in talLista)
            {
                summa += tal;
            }
            
            // Skriv ut summan
            Console.WriteLine($"Summa är {summa}");
        }
    }
}
