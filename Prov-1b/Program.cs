using System;

namespace Prov_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presentation
             Console.WriteLine("Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.\n" +
                              "Marginalskattrn räknas ut baserat på din bruttolön.\n" +
                              "Med bruttolön avses din årslön före skatt.");
           
            // Loopen! 
            string igen = "j";
            while (igen == "j")
            {
                // Först matar användaren in bruttolönen
                Console.WriteLine("Ange ditt bruttolön i kronor: ");
                string bruttolönSträng = Console.ReadLine();
          
                // Översätt från sträng till et heltal
                int bruttolön = int.Parse(bruttolönSträng);
           
                // Därefter räknas Marginalskatten
                int marginalskatt;
                if (bruttolön < 10000)
                {
                    marginalskatt = 8;
                }
                else if (bruttolön < 145000)
                {
                    marginalskatt = 22; 
                }
                else if (bruttolön < 515000) 
                {
                    marginalskatt = 33;
                }
                else
                {
                    marginalskatt = 53;
                }
          
                //  Sen räknas nettolön ut
                //  nettolön = bruttolön * (100 - marginalskatt) / 100
                int nettolön = bruttolön * (100 - marginalskatt) / 100;
           
                //  nettolönen presenteras för användaren
                Console.WriteLine($"Din nettolön blir {nettolön} kr." +
                                  $"Uträkning baserad på bruttolön {bruttolön} kr och marginalskatten {marginalskatt}%.");
                
                //  Avslutningsvis frågar programmet om användaren vill göra en ny beräkning.
                Console.Write("Vill du göra en ny beräkning? (j/n) ");
                igen = Console.ReadLine();

                //  Acceptera svaret även om användaren skriver med versaler
                igen = igen.ToLower();
            }   
        }
    }
}
