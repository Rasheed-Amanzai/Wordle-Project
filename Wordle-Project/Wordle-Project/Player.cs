using System;
using System.Collections.Generic;
using System.Text;

namespace Wordle_Project
{

    public class Player
    {
        //how many words did player guessed correctly
        public int Score { get; private set; } 
        //player's highest score
        public int HighScore { get; private set; }

        //how many guesses does it take player to guess the word correctly
        public int GuessAccuracy { get; private set; }

        //percent of winning for player 
        public double ChancesOfWinning { get; private set; }

        //numOfGamesWon(_score)/numOfGamesPlayed
        public int WinningStreak { get; private set; }




    }
}
