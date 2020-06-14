using LKuznecki.ViewModels;
using System.Windows;

namespace LKuznecki.Views
{
    /// <summary>
    /// Interaction logic for Crud.xaml
    /// </summary>
    public partial class Crud : Window
    {
        public Crud()
        {
            InitializeComponent();
            DataContext = new CrudViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2(DataContext as CrudViewModel);
            Visibility = Visibility.Hidden;
            win2.ShowDialog();
            (DataContext as CrudViewModel).RefreshList();
            Visibility = Visibility.Visible;
        }
    }
}
