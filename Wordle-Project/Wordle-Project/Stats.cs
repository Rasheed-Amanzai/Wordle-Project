using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Wordle_Project
{
    public class Stats
    {

        //Number of Games Played
        //public static int ChancesOfWinning { get; private set; }

        ////Wins/GamesPlayed
        //public static double WinningRate { get; private set; }



        //How many turns does it take player to guess the word correctly
        public static int GetGuessAccuracy()
        {
            int AvgTurns = Player._listOfTurns.Sum() / Player._listOfTurns.Count;
            return AvgTurns;
        }

        public static double GetWinningRate()
        {
            double Wins = Player.Wins;
            double PlayedGames = Player.NumOfGamesPlayed;
            return (Wins/PlayedGames)*100;
        }
    }
}
