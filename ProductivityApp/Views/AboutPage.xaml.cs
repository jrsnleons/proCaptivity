using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductivityApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        public void logoutUser(object sender, EventArgs args)
        {
            Application.Current.Properties.Clear();
            Navigation.PushAsync(new LoginPage());
        }
    }
}