/*
Projekt 1 går ut på att skapa en interaktiv dialog genom att själv skriva in koder. Jag har tagit friheten att koda en scenario där läsaren blir kritiserad för ett mord som hen har begått. Det är upp till läsaren själv hur detta spelas ut...
*/
using System;

namespace Projekt_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vittne: Ja konstapeln, den här personen här har mördat den gamla pensionären genom att putta honom ner för en trappa.");
            Console.WriteLine("Konstapeln: Va?!?!, är detta sant din förbaskade mördare!");

            string svar = Console.ReadLine().ToLower();

            if (svar == "ja")
            {
                Console.WriteLine("*Tar fram sin handpistol och skjuter dig och vittnet i huvudet och inom kort skjuter sig själv till döds efter att han fick reda på att pensionären var hans övergivande pappa som lämnade honom som barn i ett köpcenter för att köpa lite mjölk*");

                Console.ReadLine();
            }
            if (svar == "nej")

                Console.WriteLine("");
            {

            }
        }
    }
}
