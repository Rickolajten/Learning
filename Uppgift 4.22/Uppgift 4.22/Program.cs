/*
 * Skapa ett program där användaren skriver in ett meddelande som ska skrivas ut vertikalt.
 * Innan meddelandet skrivs ut så ska användaren få skriva in ett tal som anger hur många steg åt höger som det vertikala meddelande ska flyttas.
 * Om användaren skriver in 0 så ska meddelandet skrivas ut längst till vänster i fönstret, om användaren t.ex.
 * skriver in 3 så ska hela det vertikala meddelandet flyttas tre steg (tre mellanslag) åt höger.
 */

using System;

namespace Uppgift_4._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande");
            string meddelandet = Console.ReadLine();

            Console.WriteLine("Hur många steg åt höger önskar du att det vertikala meddelandet skrivs ut?");
            int stegÅtHöger = int.Parse(Console.ReadLine());

            for (int i = 0; i < meddelandet.Length; i++)
            {
                for (int x = 0; x < stegÅtHöger; x++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelandet[i]);
            }
        }
    }
}
