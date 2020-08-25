/*
 * Skapa ett menyprogram som innehåller följande alternativ:


Välj ett av följande alternativ.
1. Subtrahera ett tal med ett annat
2. Dividera ett tal med ett annat
3. Avsluta programmet
*/

using System;

namespace Uppgift_4._20
{
    class Program
    {
        static void Main(string[] args)
        {
            string användarensVal = "";

            while (användarensVal != "3")
            {
                Console.WriteLine("Välj ett av följande alternativ");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");

                användarensVal = Console.ReadLine();

                switch (användarensVal)
                {
                    
                    case "1":
                        Console.WriteLine("Skriv två tal på var sin rad.");
                        double sub1 = double.Parse(Console.ReadLine());
                        double sub2 = double.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{sub1}-{sub2}={sub1-sub2}");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Tryck på valfri knapp för att återgå till menyn");
                        Console.ResetColor();
                        Console.ReadKey(true);
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Skriv två tal på var sin rad.");
                        double div1 = double.Parse(Console.ReadLine());
                        double div2 = double.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{div1}/{div2}={div1/div2}");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Tryck på valfri knapp för att återgå till menyn");
                        Console.ResetColor();
                        Console.ReadKey(true);
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Programmet avslutas");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Du valde inte ett giltigt menyalternativ");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Tryck på valfri knapp för att återgå till menyn");
                        Console.ResetColor();
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
