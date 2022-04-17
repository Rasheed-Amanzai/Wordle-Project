using System;
using System.Collections.Generic;
using System.Text;

namespace Wordle_Project
{
    public class Game
    {
        private int _maxNumTurns = 6;

        public int CurrentTurn { get; private set; }

        public Player PlayerObj = new Player();

        public Word WordObj = new Word();

        public void StartGame()
        {
            CurrentTurn = 0;
            
            WordObj.GenerateTargetWord();
        }
    }
}
