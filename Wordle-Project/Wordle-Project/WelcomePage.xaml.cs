using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Wordle_Project
{
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
