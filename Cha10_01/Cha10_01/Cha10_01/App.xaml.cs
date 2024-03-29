﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Cha10_01
{
    public partial class App : Application
    {
        AddViewModel addViewModel;
        public App()
        {
            InitializeComponent();

            addViewModel = new AddViewModel();

            addViewModel.ResoreData();
           
            MainPage = new Page4(addViewModel);

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            addViewModel.SaveData();
        }

        protected override void OnResume()
        {
            addViewModel.ResoreData();
        }
    }
}
