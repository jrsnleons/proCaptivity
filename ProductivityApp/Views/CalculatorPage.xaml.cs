using System;
using System.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductivityApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage   
    {

        public CalculatorPage()
        {
            InitializeComponent();
        }

            private string operation;
            private decimal firstNumber;
            private bool IsoperatorCliked;

        private void Button_Clicked(object sender, EventArgs e)
        {
           var button = sender as Button;

            if(BtnRes.Text == "0" || IsoperatorCliked)
            {
                IsoperatorCliked = false;
                BtnRes.Text = button.Text;
            }
            else
            {
                BtnRes.Text += button.Text;
            }

        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            BtnRes.Text = "0";
        }

       
        private void Btn_Oper(object sender, EventArgs e)
        {
            var button = sender as Button;
            IsoperatorCliked = true;
            operation = button.Text;
            firstNumber = Convert.ToDecimal(BtnRes.Text);
        }

        private void Equal_Clicked(object sender, EventArgs e)
        {
           decimal secondNumber = Convert.ToDecimal(BtnRes.Text);
            decimal finalResult = Calculate(firstNumber,secondNumber);
            BtnRes.Text = finalResult.ToString();
        }

        public decimal Calculate(decimal firstNumber, decimal secondNumber)
        {
            decimal result = 0;
            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                result = secondNumber - firstNumber;

            }
            else if (operation == "*")
            {
                result = (firstNumber * secondNumber);

            }
            else if (operation == "/")
            {

                result = firstNumber / secondNumber;
            }
            return result;
        }
    }

}
