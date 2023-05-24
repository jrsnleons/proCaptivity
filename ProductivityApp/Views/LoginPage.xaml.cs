using ProductivityApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductivityApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            /* this.BindingContext = new LoginViewModel();*/
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(Usernametxt.Text) || string.IsNullOrEmpty(Passwordtxt.Text)))
            {
                DisplayAlert("Error", "Username or Password field is empty...", "Okay");
               
            }
            else
            {
                Navigation.PushAsync(new Home(Usernametxt.Text));
            }
           
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }
    }
}