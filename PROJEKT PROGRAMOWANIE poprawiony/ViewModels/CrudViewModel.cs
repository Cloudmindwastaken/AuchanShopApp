using LKuznecki.Commands;
using LKuznecki.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace LKuznecki.ViewModels
{
    public class CrudViewModel : INotifyPropertyChanged
    {
        private Item leftSelectedItem;
        private Item rightSelectedItem;
        private double Suma;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Item> LeftItemsList { get; set; }
        public ObservableCollection<Item> RightItemsList { get; set; }



        public Item LeftSelectedItem
        {
            get { return leftSelectedItem; }
            set
            {
                leftSelectedItem = value;
                OnPropertyChanged(nameof(LeftSelectedItem));
            }
        }
        public Item RightSelectedItem
        {
            get { return rightSelectedItem; }
            set
            {
                rightSelectedItem = value;
                OnPropertyChanged(nameof(RightSelectedItem));
            }
        }
        /// <summary>
        ///  Zaznaczanie obiektu w lewym i prawym listboxie z powiadomieniem o zmianie właściwości jeżeli by takowa zaszła
        /// </summary>

        public void Show()
        {
            throw new NotImplementedException();
        }

        public RelayCommand MoveToLeftCommand { get; set; }
        public RelayCommand MoveToRightCommand { get; set; }
        public CrudViewModel()
        {
            InitializeList(); //przypisuje nowe kolekcje
            InitializeCommands();
        }
        private void InitializeCommands()
        {
            /// Komeda transferu z prawego listboxa do lewego
            MoveToLeftCommand = new RelayCommand(button =>
            {
                if (RightSelectedItem != null)
                {
                    LeftItemsList.Add(RightSelectedItem);
                    LeftSelectedItem = RightSelectedItem;
                    RightItemsList.Remove(RightSelectedItem);
                    RightSelectedItem = null;
                }
            });
            /// Komenda transferu z lewego do prawego listboxa
            MoveToRightCommand = new RelayCommand(button =>
            {
                if (LeftSelectedItem != null)
                {
                    RightItemsList.Add(LeftSelectedItem);
                    RightSelectedItem = LeftSelectedItem;
                    LeftItemsList.Remove(LeftSelectedItem);
                    LeftSelectedItem = null;
                }
            });
        }

        private void InitializeList()
        {
            LeftItemsList = new ObservableCollection<Item> { new Item { ItemName = "Banan", ItemPrice = 1.25 }, new Item() { ItemName = "Ananas", ItemPrice = 5.88 }, new Item { ItemName = "kokos", ItemPrice = 10 }, new Item { ItemName = "Kawa", ItemPrice = 15.50 }, new Item { ItemName = "Orzechy", ItemPrice = 7.23 }, new Item { ItemName = "Kiełbasa", ItemPrice = 6.50 }, new Item { ItemName = "Ananas", ItemPrice = 6.43 }, new Item { ItemName = "Napój energetyczny", ItemPrice = 4.30 }, };
            RightItemsList = new ObservableCollection<Item>();
        }
        // Refresh list - czyści listy a tymczasowa lista temp -> dodaje przedmioty do prawej listy
        public void RefreshList()
        {
            var temporaryList = new List<Item> { new Item { ItemName = "Banan", ItemPrice = 1.25 }, new Item() { ItemName = "Ananas", ItemPrice = 5.88 }, new Item { ItemName = "kokos", ItemPrice = 10 }, new Item { ItemName = "Kawa", ItemPrice = 15.50 }, new Item { ItemName = "Orzechy", ItemPrice = 7.23 }, new Item { ItemName = "Kiełbasa", ItemPrice = 6.50 }, new Item { ItemName = "Ananas", ItemPrice = 6.43 }, new Item { ItemName = "Napój energetyczny", ItemPrice = 4.30 }, };
            LeftItemsList.Clear();
            RightItemsList.Clear();

            temporaryList.ForEach(item => LeftItemsList.Add(item));
        }
        // OnPropertyChanged  wysłanie wiadomości do interfejsu o zmianie właściwości
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));  
        }


    }
}
