using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int returnValue = randomNumber.Next(1, 11);
            int playerGuess = 0;
            int amountGuesses = 0;

            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("");
            Console.WriteLine("Guess a number between 1-10 to win a special prize!");
            while (playerGuess != returnValue)
            {
                playerGuess = int.Parse(Console.ReadLine());
                amountGuesses++;
                if (playerGuess < returnValue)
                {
                    Console.WriteLine($"Wrong, you'll have to go higher than {playerGuess}");
                }
                else if (playerGuess > returnValue)
                {
                    Console.WriteLine($"Wrong, you'll have to go lower than {playerGuess}");
                }
            }
            var amountGuesses2 = amountGuesses <= 1 ? "guess" : "guesses";
            Console.WriteLine($"Congratulations, you found the secret number {returnValue}, it took you {amountGuesses} {amountGuesses2}.");

        }
    }
}
