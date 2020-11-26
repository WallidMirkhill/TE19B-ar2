using System;

namespace Exempel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ställa en fråga coh få svar
            Console.WriteLine("Vilket är världens största land?");
            string svar;
            while (svar != "Ryssland")
            {
                svar = Console.ReadLine();
                if (svar == "Ryssland")
                {
                    Console.WriteLine("Grattulerar, Du svarade rätt!");
                }
                else
                {
                    Console.WriteLine("Du svarade fel, försök igen");
                }
            }   
        }
    }
}
