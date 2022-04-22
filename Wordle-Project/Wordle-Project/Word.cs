using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Wordle_Project
{
    public class Word
    {
        // List of common words that the program will choose from as the word that needs to be guessed
        private List<string> _usuableWords = File.ReadAllLines("UsuableWords.txt").ToList();

        // Full list of words, any of these words will be viable as a guess
        public List<string> FullWordList = File.ReadAllLines("FullWordList.txt").ToList();

        // The word that the player has to guess
        public string TargetWord { get; private set; }

        public bool isWordCorrect = false;

        public void GenerateTargetWord()
        {
            var random = new Random();
            int index = random.Next(_usuableWords.Count); // Gets a random index
            TargetWord = _usuableWords[index].ToLower();
        }

        public List<string> CheckPlayersGuess(string guess)
        {
            if (guess == TargetWord)
            {
                isWordCorrect = true;

                // Guess is correct (All green)
                return new List<string>() { "#179317", "#179317", "#179317", "#179317", "#179317" };
            }
            else
            {
                // Guess is incorrect, but is a valid word
                return GetWordFeedback(guess);
            }
        }

        private List<string> GetWordFeedback(string guess)
        {
            var wordFeedback = new List<string>();
            char[] guessChars = guess.ToCharArray(); // Convert the guess word into a array of its characters
            char[] targetChars = TargetWord.ToCharArray(); // Convert the target word into a array of its characters

            for (int i = 0; i < guessChars.Length; i++)
            {
                if (guessChars[i] == targetChars[i])
                {
                    // Character in the word and in the correct position (Green)
                    wordFeedback.Add("#179317");
                }
                else if (targetChars.Contains(guessChars[i]))
                {
                    // Character in the word, but in the incorrect position (Yellow)
                    wordFeedback.Add("#cc9c1d");
                }
                else
                {
                    // Character is not in the word (Grey)
                    wordFeedback.Add("#696969");
                }
            }

            return wordFeedback;
        }
    }
}
