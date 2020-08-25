/* Skapa ett program som ritar ut en rätvinklig triangel där användaren får bestämma triangelns sidlängd.
 * Om användaren till exempel anger sidlängden 5 så ska följande triangel ritas ut:
 * *
   **
   ***
   ****
   *****
 */

using System;

namespace Uppgift_4._24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in den rätvinkliga triangels sidlängd");
            int användarensSidlängd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < användarensSidlängd; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
        }
    }
}
