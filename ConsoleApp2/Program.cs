using System;
using System.Collections.Generic;

namespace WordFilterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store user-input words
            List<string> wordsList = new List<string>();

            // Prompt the user to enter words
            Console.WriteLine("Enter words (one per line, press Enter to finish):");
            string inputWord;
            do
            {
                inputWord = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputWord))
                {
                    wordsList.Add(inputWord);
                }
            } while (!string.IsNullOrEmpty(inputWord));

            // Filter words starting with "A"
            List<string> filteredWords = FilterWords(wordsList, "a");

            // Display the filtered words
            Console.WriteLine("\nWords starting with 'a':");
            foreach (string word in filteredWords)
            {
                Console.WriteLine(word);
            }
        }

        static List<string> FilterWords(List<string> inputWords, string startingLetter)
        {
            List<string> filteredWords = new List<string>();

            foreach (string word in inputWords)
            {
                if (word.StartsWith(startingLetter))
                {
                    filteredWords.Add(word);
                }
            }

            return filteredWords;
        }
    }
}