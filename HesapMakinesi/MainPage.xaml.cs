using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HesapMakinesi
{
    public partial class MainPage : ContentPage
    {
        double _firstNumber;
        string _operatorText;
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnNumber_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(TxtResult.Text == "0")
            {
                TxtResult.Text = string.Empty;
            }
            TxtResult.Text += button.Text;
        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            TxtResult.Text = "0";
            _firstNumber = 0;
            _operatorText = string.Empty;
        }

        private void BtnOperator_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _operatorText = button.Text;
            _firstNumber = Convert.ToDouble(TxtResult.Text);
            TxtResult.Text = "0";
        }

        private void BtnEquals_Clicked(object sender, EventArgs e)
        {
            switch (_operatorText)
            {
                case "+":
                    TxtResult.Text = (_firstNumber + Convert.ToDouble(TxtResult.Text)).ToString();
                    break;

                case "-":
                    TxtResult.Text = (_firstNumber - Convert.ToDouble(TxtResult.Text)).ToString();
                    break;

                case "*":
                    TxtResult.Text = (_firstNumber * Convert.ToDouble(TxtResult.Text)).ToString();
                    break;

                case "/":
                    TxtResult.Text = (_firstNumber / Convert.ToDouble(TxtResult.Text)).ToString();
                    break;
            }
        }
    }
}
