using System;
using System.Collections.Generic;
using System.Text;

namespace Wordle_Project
{

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
        public static double WinningRate { get; private set; }



        public Player()
        {
        }

        public void UpdateStats(bool DidPlayerWin, int amountOfTurns)
        {
            _listOfTurns.Add(amountOfTurns);
            NumOfGamesPlayed += 1;

            if (DidPlayerWin == true)
                Wins += 1;
            else
                Loses += 1;

            GuessAccuracy = Stats.GetGuessAccuracy();
            WinningRate = Stats.GetWinningRate();

        }


    }
}
