using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            // Joe Marini added a bool for keepGoing = true;
            bool keepGoing = true;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int count = 0;
            int playerGuess = 0;
            
            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            // Instead of a Try - Catch, use a Do / While Loop so as to excute at least once
            do
            {
                // Ask the user for their current guess
                Console.WriteLine("What is your guess?");
                string guess = Console.ReadLine();

                // Use the TryParse method to parse the input into a number
                bool result = Int32.TryParse(guess, out playerGuess);

                // If the player entered something other than a number, ask them again
                if (!result) {
                    Console.WriteLine("Sorry, you must enter a number. Please try again.");
                }
                else {
                    // If they enter a -1, then they can exit the game
                    if (playerGuess == -1) {
                        Console.WriteLine($"Don't quit! I was thinking of number {theNumber}, play again!");
                        keepGoing = false;
                    }
                    else
                    {
                        // Increase the guess count
                        count++;

                        // If the player answers correctly, provide the guess count and exit
                        if (playerGuess == theNumber) {
                            Console.WriteLine($"You got it correct in {count} guesses!");
                            keepGoing = false;
                        }
                        else
                        {
                            // Tell player to either guess lower or higher than the previous guess
                            Console.WriteLine("Nope, {0} than that.", playerGuess < theNumber ? "higher" : "lower");
                        }
                    }
                }
            } while (keepGoing);

            // try {
            //     Console.WriteLine("What is your guess?");
            //     string guess = Console.ReadLine();
            //     playerGuess = guess.int.Parse();
                
            //     if (playerGuess == theNumber) {
            //         count++;
            //         Console.WriteLine($"You are right! Only took {count} tries!");
            //     } else if (playerGuess == -1) {
            //         Console.WriteLine($"Don't give up... Play again!");

            //     } else {
            //         count++;
            //         Console.WriteLine($"Sorry try again!");
            //     }
            // }
            // catch {
            //     Console.WriteLine("Your guess must be an integer. Please try again!");
            // }
        }
    }
}
