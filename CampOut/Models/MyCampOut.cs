using System;
using System.Collections.Generic;

namespace CampOut.Models
{
    public class MyCampOut
    {
        public string Destination { get; set; }

        // A list of objects
        private static List<MyCampOut> _instances = new List<MyCampOut>(){};
        
        public MyCampOut(string userDestination)
        {
            Destination = userDestination;
            _instances.Add(this);
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



    }
}