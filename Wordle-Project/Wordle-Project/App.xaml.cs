﻿using System;
using WordleProject;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wordle_Project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StatisticPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
