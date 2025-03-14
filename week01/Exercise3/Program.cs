using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //Guessing Game
        {
        string playAgain = "yes";  // Variable to track if the user wants to replay
        Random random = new Random();  // Create a Random object to generate numbers

        while (playAgain.ToLower() == "yes")  // Continue looping if the user wants to play again
        {
            int magicNumber = random.Next(1, 101);  // Generate a random number between 1 and 100
            int guess = 0;  // Variable to store user guesses
            int attempts = 0;  // Counter for the number of guesses

            Console.WriteLine("I have chosen a magic number between 1 and 100.");

            while (guess != magicNumber)  // Continue guessing until the correct number is found
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());  // Read user input and convert to an integer
                attempts++;  // Increase the guess counter

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");  // Hint that the guess is too low
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");  // Hint that the guess is too high
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attempts} attempts.");  // Correct guess message
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().Trim().ToLower();  // Read input and format for comparison
        }

        Console.WriteLine("Thanks for playing!");  // Exit message when the user decides to stop
    }
    }
}