using System;

namespace Exempel_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = "Wallid";
            Console.WriteLine("Mitt namn är " + namn);

            // Med hjälp av variabelsubstitution
            Console.WriteLine($"Mitt namn är {namn}. ");

            string svar = $"Mitt förnamn är {namn}";
            Console.WriteLine(svar);
            System.Console.WriteLine();

        }
    }
}
