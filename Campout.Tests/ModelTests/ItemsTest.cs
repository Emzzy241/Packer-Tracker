using CampOut.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace CampOutTests
{
    [TestClass]
    public class ItemTest : IDisposable
    {

        public void Dispose()
        {
            Item.ClearAllItems();
        }
        // 1. Test to create instance of Item class
        [TestMethod]
        public void ItemConstructor_ReturnsInstanceOfItem_Item()
        {
            // Arrange
            Item newItem = new Item("Carlifornia Beach");

            // Assert
            Assert.AreEqual(typeof(Item), newItem.GetType());
        }   

        // 2. Test to get property ItemName in Item class
        [TestMethod]
        public void GetItemName_ReturnsItemNameProperty_String()
        {
            // Arrange
            Item newItem = new Item("Carlifornia Beach");
            string expectedItem = "Carlifornia Beach";

            // Act
            string actualItem = newItem.ItemName;

            // Assert
            Assert.AreEqual(expectedItem, actualItem);
        }

        // 3. Test to set property ItemName in Item class
        [TestMethod]
        public void SetItemName_SetsItemNameProperty_Void()
        {
            // Arrange
            Item newItem = new Item("Carlifornia Beach");
            string setItem = "Alaska Wild forests";

            // Act
            newItem.ItemName = setItem;

            // Assert
            Assert.AreEqual(setItem, newItem.ItemName);
        }

        // 4. Test to get all items from list
        [TestMethod]
        public void GetAllItems_ReturnsAllInstanceOfItems_List()
        {
            // Arrange
            Item newItem = new Item("Hello");
            Item newItem2 = new Item("Hello2");
            List<Item> expectedListOfItem = new List<Item>(){newItem, newItem2};

            // Act
            List<Item> actualList = Item.GetAllItems();

            // Assert
            CollectionAssert.AreEqual(expectedListOfItem, actualList);
        }

        // 5. Testing ClearAllItems() method
        public void ClearAllItems_DeletesAllInstanceOfItem_Void()
        {
            // Arrange
            Item newItem = new Item("Hola");
            Item newItem2 = new Item("Hello3");
            List<Item> expectedEmptyList = new List<Item>(){};
            
            // Act
            Item.ClearAllItems();
            // List<Item> expectedListOfItem = Item.GetAllItems();

            // Assert
            CollectionAssert.AreEqual(expectedEmptyList, Item.GetAllItems());
        }

        



    }
}