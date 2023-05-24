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
    public partial class instsructionPage : ContentPage
    {
        public instsructionPage()
        {
            InitializeComponent();
        }
        private void closeModal(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}