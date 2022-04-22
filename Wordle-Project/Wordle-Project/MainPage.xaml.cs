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
        List<StackLayout> rowStacks;

        public MainPage()
        {
            InitializeComponent();
            game.WordObj.ReadWordFiles();
            game.StartGame();
            rowStacks = new List<StackLayout>() { row1Stack, row2Stack, row3Stack, row4Stack, row5Stack, row6Stack };
        }

        private void Enter_Clicked(object sender, EventArgs e)
        {
            string guess = wordEntry.Text.ToLower();
            char[] guessChars = guess.ToUpper().ToCharArray();

            if (game.WordObj.FullWordList.Contains(guess))
            {
                gameMessage.Text = "";
                var guessFeedback = game.WordObj.CheckPlayersGuess(guess);
                var stackChildren = rowStacks[game.CurrentTurn - 1].Children;

                for (int i = 0; i < 5; i++)
                {
                    var frame = (Frame)stackChildren[i];
                    frame.Background = new SolidColorBrush(Color.FromHex(guessFeedback[i]));

                    var label = (Label)frame.Children[0];
                    label.Text = Convert.ToString(guessChars[i]);
                }

                if (game.WordObj.isWordCorrect || game.CurrentTurn == 6)
                {
                    EndGame();
                }

                game.CurrentTurn += 1;
            }
            else
            {
                gameMessage.Text = "Invalid Input!";
            }
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void MainMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WelcomePage());
        }

        private void EndGame()
        {
            game.PlayerObj.UpdateStats(game.WordObj.isWordCorrect, game.CurrentTurn);

            if (game.WordObj.isWordCorrect)
            {
                gameMessage.Text = "You won! Click RESET to play again.";
            }
            else
            {
                gameMessage.Text = $"You lost. The correct word was {game.WordObj.TargetWord.ToUpper()}.";
            }
        }
    }
}
