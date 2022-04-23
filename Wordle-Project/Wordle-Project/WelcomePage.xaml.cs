using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Wordle_Project
{
    // WelcomePage class is used to create the connections between StartGameButton, InstructionButton, StatsButton
    // to MainPage (game page), InstructionPage and StatisticPage respectively
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

     

        void StartGameButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        void InstructionsButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new InstructionPage());
        }

        void StatsButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StatisticPage());
        }
    }
}
