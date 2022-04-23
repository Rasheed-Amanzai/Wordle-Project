using System;
using System.Collections.Generic;
using System.Text;

namespace Wordle_Project
{
    //Fiorella - This class Player includes important properties of a player specifically as other classes such as Stats and StatisticPage use them.
    //Class Player also has a method called UpdateStats() which is called by a method called EndGame() in MainPage.xaml.cs
    //UpdateStats updates some properties of Player.
    public class Player
    {
        //How many words did player guessed correctly
        public static int Wins { get; set; }

        //Player's games loss
        public static int Loses { get; private set; }


        //list of turns - turns for each game
        public static List<int> _listOfTurns = new List<int>();
        //How many guesses does it take player to guess the word correctly
        public static int GuessAccuracy { get; private set; }

        //Number of Games Played
        public static int NumOfGamesPlayed { get; private set; }

        //Wins/GamesPlayed
        public static int WinningRate { get; private set; }

        public void UpdateStats(bool DidPlayerWin, int amountOfTurns)
        {
            _listOfTurns.Add(amountOfTurns);
            NumOfGamesPlayed += 1;

            if (DidPlayerWin == true)
                Wins += 1;
            else
                Loses += 1;

            GuessAccuracy = Stats.GetGuessAccuracy();
            WinningRate = Convert.ToInt32(Stats.GetWinningRate());

        }


    }
}
