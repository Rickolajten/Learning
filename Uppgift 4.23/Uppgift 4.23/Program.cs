/*
 * Skapa ett program där användaren får skriva in en sträng.
 * Därefter ska användaren skriva in en sträng med exakt två tecken.
 * Programmet ska undersöka om båda dessa tecken finns i den första strängen som användaren skrev in.
 * Exempelvis så ska programmet säga att båda tecknen finns om användaren först skriver in aabbcc och sedan ac.
*/

using System;

namespace Uppgift_4._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett ord: ");
            string användarensOrd = Console.ReadLine();

            Console.WriteLine("Skriv in exakt två tecken");
            string tecken = Console.ReadLine();

            bool finnsTecken1 = false;
            bool finnsTecken2 = false;

            for (int i = 0; i < användarensOrd.Length; i++)
            {
                if (användarensOrd[i] == tecken[0])
                {
                    finnsTecken1 = true;
                }
                if (användarensOrd[i] == tecken[1])
                {
                    finnsTecken2 = true;
                }
            }

            if (finnsTecken1 && finnsTecken2)
            {
                Console.WriteLine($"Båda tecknen finns i ditt ord.");
            }
            else
            {
                Console.WriteLine("Minst ett av tecknen finns inte i den första strängen");
            }
        }
    }
}
