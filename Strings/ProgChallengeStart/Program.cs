using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int count = 0;
            int playerGuess = 0;
            
            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            try {
                Console.WriteLine("What is your guess?");
                string guess = Console.ReadLine();
                playerGuess = guess.int.Parse();
                
                if (playerGuess == theNumber) {
                    count++;
                    Console.WriteLine($"You are right! Only took {count} tries!");
                } else if (playerGuess == -1) {
                    Console.WriteLine($"Don't give up... Play again!");

                } else {
                    count++;
                    Console.WriteLine($"Sorry try again!");
                }
            }
            catch {
                Console.WriteLine("Your guess must be an integer. Please try again!");
            }
        }
    }
}
