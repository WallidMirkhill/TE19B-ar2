using System;

namespace Uppgift_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programmet tillåter användaren att skriva in upp till 100 åldrar 
            int[] åldrar = new int[100];

            // Upprepa inmatning = loop
            for (int i = 0; i < åldrar.Length; i++)
            {
                 // Programmet ska först fråga användaren im en ålder 
                 Console.Write("Ange en ålder: ");
                 åldrar[i] = int.Parse(Console.ReadLine());

                  // Därefter ska programmet fråga om användaren vill skriva in en till ålder och förvänta sig svaret "j" eller "n"
                  Console.Write("Vill du mata in ett till årtal (j/n)");
                  string svar = Console.ReadLine();

                  // Om nej avsluta loopen
                  if (svar == "n")
                  {
                      break; 
                  } 

                  // Om användaren har skrivit in 100 åldrar ska programmet skriva ut "Programmet har inte plats för flera åldrar"
                  if (i == 99)
                  {
                      Console.WriteLine("Programmet har inte plats för fler åldrar");
                      break;
                  }
            }

            // Programmet ska skriva ut alla åldrar som har sparats 
            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine(åldrar[i]);
            }
        }
    }
}
