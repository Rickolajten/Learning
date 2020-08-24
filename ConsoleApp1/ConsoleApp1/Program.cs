/* Skapa ett program som skriver ut talen 10, 11, 12 o.s.v. upp till och med 30.
*  Därefter ska programmet skriva ut talen 200, 199, 198 o.s.v. ner till och med 180.
*  Slutligen ska programmet skriva ut talen 1000, 1050, 1100, 1150 o.s.v. upp till och med 1400.
*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 31; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            
            for (int y = 200; y > 179; y--)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine();
           
            for (int x = 1000; x < 1450; x += 50)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(); 

        }
    }
}
