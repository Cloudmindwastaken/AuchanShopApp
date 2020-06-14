using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LKuznecki.Models
{
    public class Item : INotifyPropertyChanged
    {
        private string itemName;
        private double itemPrice;

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Deklaracja modelu Nazwy i Ceny produktu z powiadomieniami o zmianie właściwości
        /// </summary>
        public double ItemPrice
        {
            get { return itemPrice; }
            set
            {
                itemPrice = value;
                OnPropertyChanged(nameof(ItemPrice));
            }
        }

        public string ItemName
        {
            get { return itemName; }
            set
            {
                itemName = value;
                OnPropertyChanged(nameof(ItemName));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
