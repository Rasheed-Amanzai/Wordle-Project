﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wordle_Project
{
    public class Game
    {
        public int CurrentTurn { get; set; }

        public Player PlayerObj = new Player();

        public Word WordObj = new Word();

        public void StartGame()
        {
            CurrentTurn = 1;
            
            WordObj.GenerateTargetWord();
        }
    }
}
