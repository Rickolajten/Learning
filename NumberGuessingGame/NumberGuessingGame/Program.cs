using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int returnValueEasy = randomNumber.Next(1, 11);
            int returnValueMedium = randomNumber.Next(1, 51);
            int returnValueHard = randomNumber.Next(1, 101);
            int playerGuess = 0;
            int amountGuesses = 0;
            string userChoice = string.Empty;

            while (userChoice != "4")
            {
                Console.Clear();
                Console.WriteLine("Pick a difficulty!");
                Console.WriteLine("1) Easy (number 1-10");
                Console.WriteLine("2) Medium (number 1-50");
                Console.WriteLine("3) Hard (number 1-100)");
                Console.WriteLine("4) Exit the application");
                userChoice = Console.ReadLine();
                switch (userChoice)
                {
                case "1":
                        Console.WriteLine("Welcome to the number guessing game!");
                        Console.WriteLine("");
                        Console.WriteLine("Guess a number between 1-10 to win a special prize!");
                        while (playerGuess != returnValueEasy)
                        {
                            playerGuess = int.Parse(Console.ReadLine());
                            amountGuesses++;
                            if (playerGuess < returnValueEasy)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Wrong, you'll have to go higher than {playerGuess}");
                                Console.ResetColor();
                            }
                            else if (playerGuess > returnValueEasy)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Wrong, you'll have to go lower than {playerGuess}");
                                Console.ResetColor();
                            }
                        }
                        var amountGuessesEasy = amountGuesses <= 1 ? "guess" : "guesses";
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Congratulations, you found the secret number {returnValueEasy}, it took you {amountGuesses} {amountGuessesEasy}.");
                        Console.ResetColor();
                        Console.WriteLine("Press any key to go back to the main menu");
                        Console.ReadKey(true);
                        break;

                case "2":
                        Console.WriteLine("Welcome to the number guessing game!");
                        Console.WriteLine("");
                        Console.WriteLine("Guess a number between 1-50 to win a special prize!");
                        while (playerGuess != returnValueMedium)
                        {
                            playerGuess = int.Parse(Console.ReadLine());
                            amountGuesses++;
                            if (playerGuess < returnValueMedium)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Wrong, you'll have to go higher than {playerGuess}");
                                Console.ResetColor();
                            }
                            else if (playerGuess > returnValueMedium)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Wrong, you'll have to go lower than {playerGuess}");
                                Console.ResetColor();
                            }

                        }
                        var amountGuessesMedium = amountGuesses <= 1 ? "guess" : "guesses";
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Congratulations, you found the secret number {returnValueMedium}, it took you {amountGuesses} {amountGuessesMedium}.");
                        Console.ResetColor();
                        Console.WriteLine("Press any key to go back to the main menu");
                        Console.ReadKey(true);
                        break;

                case "3":
                        Console.WriteLine("Welcome to the number guessing game!");
                        Console.WriteLine("");
                        Console.WriteLine("Guess a number between 1-100 to win a special prize!");
                        while (playerGuess != returnValueHard)
                        {
                            playerGuess = int.Parse(Console.ReadLine());
                            amountGuesses++;
                            if (playerGuess < returnValueHard)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Wrong, you'll have to go higher than {playerGuess}");
                                Console.ResetColor();
                            }
                            else if (playerGuess > returnValueHard)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Wrong, you'll have to go lower than {playerGuess}");
                                Console.ResetColor();
                            }

                        }
                        var amountGuessesHard = amountGuesses <= 1 ? "guess" : "guesses";
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Congratulations, you found the secret number {returnValueHard}, it took you {amountGuesses} {amountGuessesHard}.");
                        Console.ResetColor();
                        Console.WriteLine("Press any key to go back to the main menu");
                        Console.ReadKey(true);
                        break;

                    default:
                        Console.WriteLine("Exiting the application");
                        break;
                }
            }
        }
    }
}