/*
 * Skapa ett program som ska fungera som en tärningssimulator.
 * När användaren startar programmet ska hen få säga hur många tärningar hen vill kasta och hur många sidor varje tärning ska ha
 * , en tärning måste ju inte ha 6 sidor även om detta är vanligast.
 * Simulera därefter det antal tärningskast som användaren vill göra med det antal sidor som användaren valde.
 * Skriv ut värdet av varje tärningskast.
 */


using System;

namespace Tärningssimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();

            Console.WriteLine("Hur många sidor vill du att din tärning skall ha?");
            int antalSidor = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många tärningar vill du kasta?");
            int antalTärningar = int.Parse(Console.ReadLine());

            for (int i = 0; i < antalTärningar; i++)
            {
                int kast = randomGenerator.Next(1, antalSidor + 1);
                Console.WriteLine($"Värdet av kast {i+1}: {kast}");
            }

            Console.ReadKey();
        }
    }
}
