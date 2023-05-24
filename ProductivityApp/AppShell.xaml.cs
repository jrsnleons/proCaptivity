using ProductivityApp.ViewModels;
using ProductivityApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProductivityApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            if (!Application.Current.Properties.ContainsKey("token")){
                Navigation.PushAsync(new LoginPage());
            }
        }

    }
}
