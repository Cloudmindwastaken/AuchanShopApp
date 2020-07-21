using Microsoft.VisualStudio.TestTools.UnitTesting;
using LKuznecki;
using LKuznecki.Models;
using System.Collections.Generic;
using LKuznecki.Views;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // Test sprawdza funkcjonowanie metody sumowania cen produktów w temp list która w programie jest rightlistboxem
        public void TestMethod1()
        {

            var temporaryList = new List<Item> { new Item { ItemName = "Banan", ItemPrice = 1.25 }, new Item() { ItemName = "Ananas", ItemPrice = 5.88 }, new Item { ItemName = "kokos", ItemPrice = 10 } };
            double suma = 0;
            double expected = 17.13;
            foreach (var item in temporaryList)
            {
                suma += item.ItemPrice;
            }
            // assert
            Assert.AreEqual(expected, suma);
        }
        public void TestMethod2()
        {
            
        }
    }
}
