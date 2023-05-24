using ProductivityApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductivityApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditTodo : ContentPage
    {
        private todoList item;
        public EditTodo(todoList selectedItem)
        {
            InitializeComponent();

            item = selectedItem;
            BindingContext = item;
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {

            // Update the properties of the todo item
            item.title = titleEntry.Text;
            item.description = descriptionEntry.Text;

            // Navigate back to the MainPage
            Navigation.PopAsync();
        }

    }
}