/*
Author: Rasheed Amanzai

The Game.cs file manages the main game and initializes the Word 
and Player classes as objects to be used when playing the game.
*/

using System;
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
