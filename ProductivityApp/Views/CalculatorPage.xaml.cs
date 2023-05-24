using System;
using System.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductivityApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        private string currentNumber;
        private string operation;
        private double firstNumber;
        private double secondNumber;

        public CalculatorPage()
        {
            InitializeComponent();
            currentNumber = string.Empty;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                currentNumber += button.Text;
                resultLabel.Text = currentNumber;
            }
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            currentNumber = string.Empty;
            firstNumber = 0;
            secondNumber = 0;
            operation = string.Empty;
            resultLabel.Text = string.Empty;
        }

        private void Equal_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentNumber) && !string.IsNullOrEmpty(operation))
            {
                double secondNumber;
                if (double.TryParse(currentNumber, out secondNumber))
                {
                    double result;
                    switch (operation)
                    {
                        case "+":
                            result = firstNumber + secondNumber;
                            break;
                        case "-":
                            result = firstNumber - secondNumber;
                            break;
                        case "*":
                            result = firstNumber * secondNumber;
                            break;
                        case "/":
                            if (secondNumber != 0)
                                result = firstNumber / secondNumber;
                            else
                            {
                                resultLabel.Text = "Error";
                                return;
                            }
                            break;
                        default:
                            resultLabel.Text = "Error";
                            return;
                    }

                    resultLabel.Text = result.ToString();
                    firstNumber = result;
                    currentNumber = result.ToString();
                    operation = string.Empty;
                }
                else
                {
                    resultLabel.Text = "Error";
                }
            }
        }




    }
}
