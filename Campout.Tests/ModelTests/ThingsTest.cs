using CampOut.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace CampOutTests
{
    [TestClass]
    public class ThingsTest
    {
        [TestMethod]
        public void TestConstructor_ReturnsInstanceOfThings_Things()
        {
            // Arrange
            Things newThing = new Things();

            // Assert
            Assert.AreEqual(typeof(Things), newThing.GetType());
        }   

        
    }
}