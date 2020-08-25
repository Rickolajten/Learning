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
