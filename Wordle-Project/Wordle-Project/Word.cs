/*
Author: Rasheed Amanzai

The Word.cs file manages all the information and tasks related to the words, such as: 
list(s) of words, generating a random target word, checking the player’s guess and returning feedback, etc.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Wordle_Project
{
    public class Word
    {
        // List of common words that the program will choose from as the word that needs to be guessed
        private List<string> _usuableWords = new List<string>();

        // Full list of words, any of these words will be viable as a guess
        public List<string> FullWordList = new List<string>();

        // The word that the player has to guess
        public string TargetWord { get; private set; }

        public bool isWordCorrect = false;

        public void ReadWordFiles()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            Stream stream1 = assembly.GetManifestResourceStream("Wordle-Project.UsuableWords.txt");
            Stream stream2 = assembly.GetManifestResourceStream("Wordle-Project.FullWordList.txt");

            using (var reader = new System.IO.StreamReader(stream1))
            {
                while(!reader.EndOfStream)
                {
                    _usuableWords.Add(reader.ReadLine());
                }
            }

            using (var reader = new System.IO.StreamReader(stream2))
            {
                while (!reader.EndOfStream)
                {
                    FullWordList.Add(reader.ReadLine());
                }
            }
        }

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

            IDictionary<char, int> guessCharCount = GetWordCharCount(guessChars);
            IDictionary<char, int> targetCharCount = GetWordCharCount(targetChars);

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

            /* Handles situations where the guess word has double (or triple) letters, but the target word only has one of those letters. 
             For example, if the guess word is "dress" and the target word is "sweat", this makes sure that only the first s of 
            "dress" is marked yellow, and the other will be grey (before I ran into the problem of where both was marked as yellow)*/
            foreach (var item in targetCharCount)
            {
                char letter = char.Parse(item.Key.ToString());

                // Checks to see if: the letter is the same in both words, the letter count is 1 in the target word, and greater than/equal to 2 in the guess word
                if (guessCharCount.ContainsKey(item.Key) && item.Value == 1 && guessCharCount[letter] >= 2)
                {
                    int lastYellowIndex = 0;

                    // Gets the last occurance where the letter is marked as yellow
                    for (int i = 0;i < guessChars.Length; i++)
                    {
                        if (guessChars[i] == letter && wordFeedback[i] == "#cc9c1d")
                        {
                            lastYellowIndex = i;
                        }
                    }

                    // Then changes the colour of that letter position to grey
                    wordFeedback[lastYellowIndex] = "#696969";
                }
            }

            return wordFeedback;
        }

        // Gets the amount of times each letter is in the word. For example, the word "guess" has: 1 g, 1 u, 1 e, and 2 s
        private IDictionary<char, int> GetWordCharCount(char[] charArray)
        {
            IDictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in charArray)
            {
                if (!charCount.ContainsKey(c))
                {
                    charCount[c] = 1;
                }
                else
                {
                    charCount[c]++;
                }
            }

            return charCount;
        }
    }
}
