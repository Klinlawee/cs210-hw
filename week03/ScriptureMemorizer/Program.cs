using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Create a scripture object
        Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world that he gave his only Son");

        // Display the verse with some random words hidden
        scripture.HideRandomWords(3);
        scripture.DisplayVerse();

        // Simulate user guesses
        while (true)
        {
            Console.WriteLine("Guess a hidden word or type 'exit' to quit:");
            string guess = Console.ReadLine();

            // If user types "exit", break out of the loop
            if (guess.ToLower() == "exit")
            {
                Console.WriteLine("Thank you for playing! Goodbye.");
                break;
            }

            // Check the user's guess and display the updated verse
            scripture.CheckGuess(guess);
            scripture.DisplayVerse();
        }
    }
}