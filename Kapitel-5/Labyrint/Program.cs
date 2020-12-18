using System;

namespace Labyrint
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en labyrint
            int[,] labyrint = {
                {1, 1, 1, 1, 1, 1, 1},
                {1, 0, 0, 0, 0, 0, 1},
                {1, 0, 1, 1, 1, 0, 1},
                {1, 0, 1, 1, 0, 0, 1},
                {1, 0, 1, 1, 0, 1, 1},
                {1, 0, 0, 0, 0, 0, 1},
                {1, 0, 1, 1, 1, 1, 1}
            };

            // Slumpa fram in en figur i labyrinten
            Random slumpMotor = new Random();
            while (true)
            {
                // Slumpa fram koordinater 
                int x = slumpMotor.Next(0, 7); // 0-6
                int y = slumpMotor.Next(0, 7); // 0-6

                // Hamnar vi i en gång 
                if (labyrint[y, x] == 0)
                {
                    labyrint[y, x] = 2;
                    break;                
                }
            }

            // För att skriva ut Entities
            Console.OutputEncoding = System.Text.Encoding.Default;

            // Skriva ut labyrinten
            // Loopa igenom raden för rad, dvs i y-led
            for (int y = 0; y < 7; y++)
            {
                // Loopa igenom kolumnvis, dvs x-led
                for (int x = 0; x < 7; x++)
                {
                    switch (labyrint[y, x])
                    {
                        case 1: // En vägg
                        Console.Write('\u2B1C');
                        break;

                        case 2: // En figur
                        Console.Write("");
                        break;

                        case 3: // En gång
                        Console.Write('\u2B1C');
                        break;
                    }
                }
            }
        }    
    }
}
