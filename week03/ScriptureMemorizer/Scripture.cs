using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(string book, int chapter, int verse, string verseText)
    {
        Reference = new Reference(book, chapter, verse);
        Words = new List<Word>();

        // Split the verse into words and create Word objects
        foreach (var word in verseText.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberOfWordsToHide)
        {
            int index = rand.Next(Words.Count);
            Word word = Words[index];

            // Only hide the word if it is not already hidden
            if (!word.IsHidden)
            {
                word.Hide();
                hiddenCount++;
            }
        }
    }

    public void DisplayVerse()
    {
        Console.WriteLine(Reference.GetDisplayText());
        foreach (var word in Words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public void CheckGuess(string guess)
    {
        foreach (var word in Words)
        {
            if (word.IsHidden && word.Text.Equals(guess, StringComparison.OrdinalIgnoreCase))
            {
                word.Unhide();
                Console.WriteLine($"Correct! The word '{guess}' was revealed.");
                return;
            }
        }
        Console.WriteLine("Incorrect guess. Try again!");
    }
}
