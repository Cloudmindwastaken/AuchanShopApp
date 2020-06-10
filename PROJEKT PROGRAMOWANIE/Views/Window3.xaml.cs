using System;
using LKuznecki.Views;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;

namespace LKuznecki.Views
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// Deklaracja funkcjonalności przycisków interfejsu do płatności kartą
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Count() >= 4)
                return;

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "8";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}8";
            }
        }
        private void eightButtonClick(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Count() >= 4)
                return;
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "8";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}8";
            }
        }

        private void nineButtonClick(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Count() >= 4)
                return;

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "9";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}9";
            }
        }

        private void fourButtonClick(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Count() >= 4)
                return;
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "4";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}4";
            }
        }

        private void fiveButtonClick(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Count() >= 4)
                return;

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "5";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}5";
            }
        }

        private void sixButtonClick(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Count() >= 4)
                return;

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "6";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}6";
            }
        }

        private void oneButtonClick(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Count() >= 4)
                return;
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "1";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}1";
            }
        }

        private void twoButtonClick(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Count() >= 4)
                return;
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "2";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}2";
            }
        }

        private void threeButtonClick(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Count() >= 4)
                return;
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "3";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}3";
            }
        }

        private void zeroButtonClick(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Count() >= 4)
                return;
            try
            {
                if (resultLabel.Content.ToString() == "0")
                {
                    resultLabel.Content = "0";
                }
                else
                {
                    resultLabel.Content = $"{resultLabel.Content}0";
                }
            }
            catch (Exception ex)
            {
                resultLabel.Content = ex.Message;
            }
        }

        private void EnterButtonClick(object sender, RoutedEventArgs e)
        {
            Window4 objWindow4 = new Window4();
            this.Visibility = Visibility.Hidden; // Chowamy akutalne okno
            objWindow4.Show();

        }

        private void ClearClick(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }
        // W przypadku złego wpisania możemy wyczyścić pin i wpisać go od nowa
    }
}
