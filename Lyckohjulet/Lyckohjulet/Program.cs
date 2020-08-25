/* 
 * Skapa ett program som ska fungera som ett lyckohjul.
 * När användaren kör programmet får hen välja ett tal från 1 till 10 som hen tror att lyckohjulet kommer att stanna på.
 * Slumpa därefter fram ett tal från 1 till 10 och säg till användaren vilket tal det blev.
 * Berätta också för användaren om hen vann eller förlorade.
 */

using System;

namespace Lyckohjulet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slumptalsGenerator = new Random();
            int slumpatTal = slumptalsGenerator.Next(1, 11);
            Console.WriteLine("Vilket tal från 1-10 tror du att hjulet kommer stanna på?");
            int användarensTal = int.Parse(Console.ReadLine());

            if (användarensTal == slumpatTal)
            {
                Console.WriteLine($"Du vann, korrekt tal var {slumpatTal}");
            }
            else
            {
                Console.WriteLine($"Du förlorade, korrekt tal var {slumpatTal}");
            }
        }
    }
}
