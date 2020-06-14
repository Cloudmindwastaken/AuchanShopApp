using LKuznecki.Models;
using LKuznecki.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LKuznecki.Views
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// Pressing Button Gotowka PayU Bon results in moving to window4
    /// Pressing Karta button resutls in moving to window3
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();


        }
        public CrudViewModel CrudViewModel { get; }
        public Window2(CrudViewModel crudViewModel)
        {
            CrudViewModel = crudViewModel;
            DataContext = crudViewModel;
            InitializeComponent();

        }



        private void GotowkaButtonClick(object sender, RoutedEventArgs e)
        {
            Window4 objWindow4 = new Window4();
            this.Visibility = Visibility.Hidden; // Chowamy akutalne okno
            objWindow4.Show();
        }

        private void PayUButtonClick(object sender, RoutedEventArgs e)
        {
            Window4 objWindow4 = new Window4();
            this.Visibility = Visibility.Hidden; // Chowamy akutalne okno
            objWindow4.Show();
        }

        private void BonButtonClick(object sender, RoutedEventArgs e)
        {
            Window4 objWindow4 = new Window4();
            this.Visibility = Visibility.Hidden; // Chowamy akutalne okno
            objWindow4.Show();
        }
        // Sumuje wybrane przedmioty w crud i zlicza ich cene po kliknięciu
        /// <summary>
        ///  /// <returns>
        /// The sum of two integers.
        /// </returns>
        /// <example>
        /// <code>
        /// var temporaryList = new List<Item> { new Item { ItemName = "Banan", ItemPrice = 1.25 }
        /// foreach (var item in temporaryList)
        /// {
        ///     resultLabel.content = "suma+=item.Itemprice"
        /// }
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resultButton_Click_1(object sender, RoutedEventArgs e)
        {
            double suma = 0;
            foreach (var item in CrudViewModel.RightItemsList)
            {
                suma += item.ItemPrice;
            }
            resultLabel.Content = suma.ToString();
        }
        
        private void PlatnoscKartaButtonClick(object sender, RoutedEventArgs e)
        {
            Window3 objWindow3 = new Window3();
            this.Visibility = Visibility.Hidden; // Chowamy akutalne okno
            objWindow3.Show();
        }
    }
}
