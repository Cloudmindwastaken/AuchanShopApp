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
    /// 
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        // Jeżeli spróbojemy wpisać więcej cyfr niż zero kod się nie wykona następuje return
        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Count() >= 4)
                return;
            // Dla początkowej wartości resultlabel 0 po wcisnięciu 7 wynikiem będzie 7 a gdy już wpisane są cyfry to dodaje 7 na koniec
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}7";
            }
        }
        private void eightButtonClick(object sender, RoutedEventArgs e)
        {
            // Dla początkowej wartości resultlabel 0 po wcisnięciu 8 wynikiem będzie 8 a gdy już wpisane są cyfry to dodaje 8 na koniec
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
            // Dla początkowej wartości resultlabel 0 po wcisnięciu 9 wynikiem będzie 9 a gdy już wpisane są cyfry to dodaje 9 na koniec
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
            // Dla początkowej wartości resultlabel 0 po wcisnięciu 4 wynikiem będzie 4 a gdy już wpisane są cyfry to dodaje 4 na koniec
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
            // Dla początkowej wartości resultlabel 0 po wcisnięciu 5 wynikiem będzie 5 a gdy już wpisane są cyfry to dodaje 5 na koniec
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
            // Dla początkowej wartości resultlabel 0 po wcisnięciu 6 wynikiem będzie 6 a gdy już wpisane są cyfry to dodaje 6 na koniec
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
            // Dla początkowej wartości resultlabel 0 po wcisnięciu 1 wynikiem będzie 1 a gdy już wpisane są cyfry to dodaje 1 na koniec
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
            // Dla początkowej wartości resultlabel 0 po wcisnięciu 2 wynikiem będzie 2 a gdy już wpisane są cyfry to dodaje 2 na koniec
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
            // Dla początkowej wartości resultlabel 0 po wcisnięciu 3 wynikiem będzie 3 a gdy już wpisane są cyfry to dodaje 3 na koniec
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
            // Dla początkowej wartości resultlabel 0 po wcisnięciu 0 wynikiem będzie 0 a gdy już wpisane są cyfry to dodaje 0 na koniec
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
            // Chowa okno bieżace i wyświetla window4
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
