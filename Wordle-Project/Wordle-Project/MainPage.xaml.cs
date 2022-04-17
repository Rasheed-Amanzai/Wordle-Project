using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Wordle_Project
{
    public partial class MainPage : ContentPage
    {
        Game game = new Game();

        public MainPage()
        {
            InitializeComponent();
            game.StartGame();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (game.WordObj.FullWordList.Contains(wordEntry.Text))
            {
                var guessFeedback = game.WordObj.CheckPlayersGuess(wordEntry.Text);
                //var stackChildren = row1Stack.Children.ToList();

                for (int i = 0; i < guessFeedback.Count; i++)
                {
                    //stackChildren[i].
                }
            }
            else
            {
                gameMessage.Text = "Invalid Input!";
            }
        }
    }
}
