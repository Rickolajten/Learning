/* 
 * Det finns en klassisk programmeringsuppgift som kallas Fizz Buzz.
 * Uppgiften är denna: Skapa ett program som skriver ut talen 1 till 100 på var sin rad.
 * Men talen som är delbara med 3 ska inte skrivas ut, istället ska ordet Fizz skrivas.
 * Talen som är delbara med 5 ska inte heller skrivas ut, skriv istället ut Buzz.
 * Tal som är delbara med både 3 och 5 ska ersättas med FizzBuzz. 
 */

using System;

namespace Uppgift_4._19
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
