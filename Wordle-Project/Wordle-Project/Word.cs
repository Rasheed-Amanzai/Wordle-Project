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
        private List<string> _usuableWords = File.ReadAllLines(@"UsuableWords.txt").ToList();

        // Full list of words, any of these words will be viable as a guess
        private List<string> _fullWordList = File.ReadAllLines(@"FullWordList.txt").ToList();

        // The word that the player has to guess
        public string TargetWord { get; private set; }

        public void GenerateTargetWord()
        {
            var random = new Random();
            int index = random.Next(_usuableWords.Count); // Gets a random index
            TargetWord = _usuableWords[index];
        }

        public int CheckPlayersGuess(string guess)
        {
            if (guess == TargetWord)
            {
                // Guess is correct
                return 1;
            }
            else if (_fullWordList.Contains(guess))
            {
                // Guess is incorrect, but is a valid word
                return 2;
            }
            else
            {
                // Guess is a invalid word
                return 3;
            }
        }
    }
}
