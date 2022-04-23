using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Wordle_Project
{
    //Fiorella - StatisticPage is used to take the labels (WinsLabel, LosesLabel, GuessAccuracyLabel, WinningRateLabel)
    //from StatisticPage.xaml and putting value to them with the actual values of the stats,
    //also the actual stats values are converted into string as labels operate with strings.
    //Additionally, this page makes the connection between the button BackToMainMenu and WelcomePage()
    //which leads user to WelcomePage as soon as it is Clicked

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
            WinningRateLabel.Text = $"{WinningRateString}%";





        }

     

        void BackToMainMenu_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new WelcomePage());
        }

    }
}
