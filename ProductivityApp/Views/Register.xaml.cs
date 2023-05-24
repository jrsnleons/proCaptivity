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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameR.Text) || string.IsNullOrEmpty(PasswordR.Text))
            {
                DisplayAlert("Error", "Username or Password is empty", "Okay"); 
            }
            else if (PasswordR.Text != ConPasswordR.Text)
            {
                DisplayAlert("Error", "Password does not match", "Okay");
            }
            else
            {
                DisplayAlert("User created!", "Congratulations, the user has been created", "Okay");
                Navigation.PushAsync(new Home(UsernameR.Text));
            }
        }
    }
}