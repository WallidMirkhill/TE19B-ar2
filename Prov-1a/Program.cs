/*
Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.
*/

using System;

namespace Prov_1a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programmet ska be läsaren att mata in en lön
            Console.WriteLine("Ange ditt bruttolön i kr: ");
            string bruttolön = Console.ReadLine();

            Console.WriteLine("Du får " + bruttolön + " i bruttolön");

        }
    }
}
