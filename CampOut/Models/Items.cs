using System;
using System.Collections.Generic;

namespace CampOut.Models
{
    public class Item
    {
        public string ItemName { get; set; }

        public int Id { get; }
        
        

        private static List<Item> _myInstance = new List<Item>(){};
        
        public Item(string myItemName)
        {
            ItemName = myItemName;
            _myInstance.Add(this);
            Id = _myInstance.Count;
        }

        public static List<Item> GetAllItems()
        {
            return _myInstance;
        } 
        public static void ClearAllItems()
        {
            _myInstance.Clear();
        }

        public static Item FindItem(int itemId)
        {
            return _myInstance[itemId -1];
        }


        
    }
}