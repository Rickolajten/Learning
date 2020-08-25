/* I 21:an kommer du att spela mot datorn och försöka tvinga datorn att få över 21 poäng.
   Både du och datorn får poäng genom att dra kort, varje kort är värt 1 – 10 poäng.
   När spelet börjar dras två kort till både dig och datorn.
   Därefter får du dra hur många kort som du vill tills du är nöjd med din totalpoäng, du vill komma så nära 21 som möjligt utan att få mer än 21 poäng.
   När du inte vill dra fler kort så kommer datorn att dra kort tills den har mer eller lika många poäng som dig.
   Du vinner om datorn får mer än totalt 21 poäng när den håller på att dra kort. Datorn vinner om den har mer poäng än dig när spelet är slut så länge som datorn inte har mer än 21 poäng.
   Om det skulle bli lika i poäng så vinner datorn.
   Om du får mer än 21 poäng när du drar kort så har du förlorat.
*/

using System;

namespace SpeletTjugoEttan
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxKortPoäng = 5;
            int minKortPoäng = 1;
            int poängFörAttVinna = 21;
            Random slump = new Random();
            string senasteVinnaren = "Ingen har vunnit ännu";
            Console.WriteLine("Välkommen till 21:an!");

            string användarensMenyval = "";

            while (användarensMenyval != "4")
            {

                Console.WriteLine("1. Spela en omgång av 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Visa spelets regler");
                Console.WriteLine("4. Avsluta");
                användarensMenyval = Console.ReadLine();


                switch (användarensMenyval)
                {
                    case "1":
                        int datornsPoäng = 0;
                        int spelarensPoäng = 0;
                        Console.WriteLine("Nu kommer två kort dras per spelare");
                        datornsPoäng += slump.Next(minKortPoäng, maxKortPoäng);
                        datornsPoäng += slump.Next(minKortPoäng, maxKortPoäng);
                        spelarensPoäng += slump.Next(minKortPoäng, maxKortPoäng);
                        spelarensPoäng += slump.Next(minKortPoäng, maxKortPoäng);

                        // Låt användaren dra fler kort
                        string kortVal = "";
                        while (kortVal != "n" && spelarensPoäng <= poängFörAttVinna)
                        {
                            färgKanalSpelaren();
                            Console.WriteLine($"Din poäng: {spelarensPoäng}");
                            färgClear();
                            Console.WriteLine($"Datorns poäng: {datornsPoäng}");
                            Console.WriteLine("Vill du ha ett till kort? (j/n)");
                            kortVal = Console.ReadLine();
                            
                            switch (kortVal)
                            {
                                case "j":
                                    int nyPoäng = slump.Next(minKortPoäng, maxKortPoäng);
                                    spelarensPoäng += nyPoäng;
                                    Console.WriteLine($"Ditt nya kort är värt {nyPoäng} poäng");
                                    Console.WriteLine($"Din totalpoäng är {spelarensPoäng}");
                                    break;

                                case "n":
                                    break;

                                default:
                                    Console.WriteLine("Du valde inte ett giltigt alternativ");
                                    break;
                            }
                        }
                        // Gå tillbaka till huvudmenyn om användaren har över 21
                        if (spelarensPoäng > poängFörAttVinna)
                        {
                            Console.WriteLine("Du har mer än 21 och har förlorat");
                            break;
                        }

                        // Datorn drar kort tills den vinner eller går över 21
                        while (datornsPoäng < spelarensPoäng && datornsPoäng <= poängFörAttVinna)
                        {
                            int datornsNyaPoäng = slump.Next(minKortPoäng, maxKortPoäng);
                            datornsPoäng += datornsNyaPoäng;
                            Console.WriteLine($"Datorn drog ett kort värt {datornsNyaPoäng}");
                        }
                        färgKanalSpelaren();
                        Console.WriteLine($"Din poäng: {spelarensPoäng}");
                        färgClear();
                        Console.WriteLine($"Datorns poäng: {datornsPoäng}");

                        // Undersök vem som vann
                        if (datornsPoäng > poängFörAttVinna)
                        {
                            Console.WriteLine("Du har vunnit!");
                            Console.WriteLine("Skriv in ditt namn");
                            senasteVinnaren = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Datorn har vunnit!");
                        }
                        break;


                    case "2":
                        Console.WriteLine($"Senaste vinnaren: {senasteVinnaren}");
                        break;

                    case "3":
                        Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng.");
                        Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1-10 poäng.");
                        Console.WriteLine("Om du får mer än 21 poäng har du förlorat.");
                        Console.WriteLine("Både du och datorn får två kort i början. Därefter får du");
                        Console.WriteLine("dra fler kort tills du är nöjd eller får över 21.");
                        Console.WriteLine("När du är färdig drar datorn kort till den har");
                        Console.WriteLine("mer poäng än dig eller över 21 poäng.");
                        break;

                    case "4":
                        Console.WriteLine("");
                        break;

                    default:
                        Console.WriteLine("Menyvalet är ogiltigt.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void färgKanalSpelaren()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        static void färgClear()
        {
            Console.ResetColor();
        }
    }
}
