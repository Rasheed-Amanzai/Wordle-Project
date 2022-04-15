using System;
using System.Collections.Generic;
using System.Text;

namespace Wordle_Project
{
    public class Game
    {
        private int _maxNumTurns = 6;

        public int CurrentTurn { get; private set; }

        public Player WordlePlayer = new Player();

        public void StartGame()
        {
            CurrentTurn = 0;
            
            Word word = new Word();
            word.GenerateTargetWord();
        }
    }
}
