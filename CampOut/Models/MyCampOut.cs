using System;
using System.Collections.Generic;

namespace CampOut.Models
{
    public class MyCampOut
    {
        public string Destination { get; set; }
        public int Id { get; }

        // A List to store all items related to a certain MyCampout instance.
        // So what this list does is to store items that are related to a certain destination.
        public List<Item> ItemsList { get; set; }
        
        

        // A list of objects
        private static List<MyCampOut> _instances = new List<MyCampOut>(){};
        
        public MyCampOut(string userDestination)
        {
            Destination = userDestination;
            _instances.Add(this);
            // Setting the value for the id property right inside the constructor; A read-only property
            Id = _instances.Count;
            // For the new list of items we just created
            ItemsList = new List<Item>(){};
        }

        // A Method that returns all instances made from the MyCampOut class

        public static List<MyCampOut> GetAllObj()
        {
            return _instances;
        }

        // A Method to clear all instances from list
        public static void ClearAllObj()
        {
            // .Clear() is a method that can be called on Lists; the duty of the method is to remove all objects in list
            _instances.Clear();
        }

        // A method to find each object in the class with its id
        public static MyCampOut FindObj(int objId)
        {
            return _instances[objId - 1];
        }

        // A Method to add an Item to a certain Category(i.e MyCampOut object)
        public void AddItem(Item newItem)
        {
            // Making use of the new list I created to help in store Item inside a specific category(i.e MyCampOut)
            ItemsList.Add(newItem);
        }



    }
}