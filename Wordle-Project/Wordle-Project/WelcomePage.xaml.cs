using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WordleProject
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new InstructionPage());
        }
    }
}
