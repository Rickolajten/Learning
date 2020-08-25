/*
 * Låt användaren skriva in ett heltal. Skriv ut samma till till användaren
 * fast öka först alla siffror i talet med 1, nior ska ändras till nollor.
 * T.ex. ska talet 415932 ändras till 526043.
 */

using System;

namespace Uppgift_4._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string helTal = Console.ReadLine();

            for (int i = 0; i < helTal.Length; i++)
            {
                string tecken = helTal[i].ToString();
                int siffra = int.Parse(tecken);

                if (siffra == 9)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write(siffra + 1);
                }
            }
        }
    }
}
