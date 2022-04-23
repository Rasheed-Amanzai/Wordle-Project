using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Wordle_Project
{
    // Fiorella - Class Stats is used to make calculations for some of the properties of class Player
    // This class has 2 methods, GetGuessAccuracy() and GetWinningRate(), GetGuessAccuracy() returns a value for GuessAccuracy and
    // GetWinningRate() returns a value for WinningRate
    public class Stats
    {

       

        //How many turns does it take player to guess the word correctly
        public static int GetGuessAccuracy()
        {
            int AvgTurns = Player._listOfTurns.Sum() / Player._listOfTurns.Count;
            return AvgTurns;
        }

        //Returns a percentage of winning rate
        public static double GetWinningRate()
        {
            double Wins = Player.Wins;
            double PlayedGames = Player.NumOfGamesPlayed;
     

            return(Wins/PlayedGames)*100;
        }
    }
}
