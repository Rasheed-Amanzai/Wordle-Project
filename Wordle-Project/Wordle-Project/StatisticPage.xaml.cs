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
            Player plyr = new Player();

            string ScoreLabelInt = Convert.ToString(plyr.Score);
            ScoreLabel.Text = ScoreLabelInt;

            string HighestScoreLabelInt = Convert.ToString(plyr.HighestScore);
            HighestScoreLabel.Text = HighestScoreLabelInt;

            string GuessAccuracyInt = Convert.ToString(plyr.GuessAccuracy);
            GuessAccuracyLabel.Text = GuessAccuracyInt;

            string ChancesOfWinningInt = Convert.ToString(plyr.ChancesOfWinning);
            HighestScoreLabel.Text = HighestScoreLabelInt;





        }

        void BackToGame_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }


    }
}
