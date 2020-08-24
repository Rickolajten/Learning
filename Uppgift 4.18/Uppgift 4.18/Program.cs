/* 
 * Skapa ett program där användaren ska skriva in ett heltal.
 * Efter att hen har gjort det ska programmet fråga om användaren vill skriva in ett heltal till eller inte.
 * Användaren ska fortsätta att få skriva in nya heltal ända tills hen inte vill göra det mer.
 * När användaren inte vill skriva in mer tal ska programmet skriva ut vilket som var det största talet som användaren skrev in.
 */

using System;

namespace Uppgift_4._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            int störst = int.Parse(Console.ReadLine());

            Console.WriteLine("Vill du skriva in ett tal till? Skriv j eller n");
            string skrivaIgen = Console.ReadLine();
            while (skrivaIgen == "j")
            {
                Console.WriteLine("Skriv in ett tal: ");
                int nyttTal = int.Parse(Console.ReadLine());

                if (nyttTal > störst)
                {
                    störst = nyttTal;
                }

                Console.WriteLine($"Det största talet är {störst}");
            }
        }
    }
}
