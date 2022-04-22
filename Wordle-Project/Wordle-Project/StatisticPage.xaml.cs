using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Wordle_Project
{
    public partial class StatisticPage : ContentPage
    {
        public StatisticPage()
        {

            InitializeComponent();
        

            string WinsString = Convert.ToString(Player.Wins);
            WinsLabel.Text = WinsString;

            string LosesString = Convert.ToString(Player.Loses);
            LosesLabel.Text = LosesString;

            string GuessAccuracyString = Convert.ToString(Player.GuessAccuracy);
            GuessAccuracyLabel.Text = GuessAccuracyString;

            string WinningRateString = Convert.ToString(Player.WinningRate);
            WinningRateLabel.Text = WinningRateString;





        }

        void BackToGame_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }


    }
}
