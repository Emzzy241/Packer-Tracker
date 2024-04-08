using Microsoft.VisualStudio.TestTools.UnitTesting;
using CampOut.Models;
using System;
using System.Collections.Generic;


namespace CampOutTests.Models
{
    [TestClass]
    public class MyCampOutTests : IDisposable
    {
        // IDisposable is an interface. And it must implements A Dispose() method which runs after every test
        // And we want to clear our list after evry test.

        public void Dispose()
        {
            MyCampOut.ClearAllObj();
        }

        // 1st Test: Test for MyCampOut Constructor
        [TestMethod]
        public void CampOutConstructor_ReturnsInstanceOfClass_CampOut()
        {
            // Arrange
            MyCampOut newOuting = new MyCampOut("Osaka, Japan");

            // Assert
            Assert.AreEqual(typeof(MyCampOut), newOuting.GetType());
        }        

        // 2nd Test: Test to get the destination property of MyCampOut class
        [TestMethod]
        public void GetDestination_ReturnsDestinationOfCampOut_String()
        {
            // Arrange
            MyCampOut newOuting = new MyCampOut("Osaka, Japan");
            string ExpectedDestination = "Osaka, Japan";

            // Act
            string ActualDestination = newOuting.Destination;

            // Assert
            Assert.AreEqual(ExpectedDestination, ActualDestination);
        }

        // 3rd Test:  Test to set the destination property of MyCampOut class
        [TestMethod]
        public void SetDestination_SetsDestinationOfCampOut_Void()
        {
            // Arrange
            MyCampOut newOuting = new MyCampOut("Osaka, Japan");
            string newDestination = "Auckland, New Zealand";

            // Act
            newOuting.Destination = newDestination;

            // Assert
            Assert.AreEqual(newDestination, newOuting.Destination);
        }

        // 4th Test: Test to get all instances of the class MyCampOut; remember, an ovject is an instance of a class.
        // So, we are getting all objects created with the MyCampOut class
        [TestMethod]
        public void GetAll_ReturnsAllInstanceOfClass_List()
        {
            // Arrange
            MyCampOut newOuting1 = new MyCampOut("Toronto, Canada");
            MyCampOut newOuting2 = new MyCampOut("Kentucky, United States");
            MyCampOut newOuting3 = new MyCampOut("Auckland, New Zealand");

            List<MyCampOut> expectedList = new List<MyCampOut>(){newOuting1, newOuting2, newOuting3};

            // Act
            List<MyCampOut> actualList = MyCampOut.GetAllObj();

            // Assert
            CollectionAssert.AreEqual(expectedList, actualList);
        }

        // 5th Test: Test to remove all MyCampOut instances from the list
        [TestMethod]
        public void ClearAll_RemovesAllInstancesOfMyCampOutFromList_Void()
        {
            // Arrange
            MyCampOut newOuting1 = new MyCampOut("Toronto, Canada");
            MyCampOut newOuting2 = new MyCampOut("Kentucky, United States");
            MyCampOut newOuting3 = new MyCampOut("Auckland, New Zealand");

            List<MyCampOut> expectedList = new List<MyCampOut>(){};

            // Act
            MyCampOut.ClearAllObj();

            List<MyCampOut> actualList = MyCampOut.GetAllObj();

            // Assert
            CollectionAssert.AreEqual(expectedList, actualList);

        }


        // 6th Test: Test to find each destination in MyCampOut class
        [TestMethod]
        public void FindInstance_ReturnsEachObjectId_Int()
        {
            // Arrange
            MyCampOut newOuting1 = new MyCampOut("Osaka, Japan");
            MyCampOut newOuting2 = new MyCampOut("Auckland, New Zealand");
            int ExpectedId1 = 1;
            int ExpectedId2 = 2;

            // Act
            int actualId1 = newOuting1.Id;
            int actualId2 = newOuting2.Id;

            // Assert
            Assert.AreEqual(ExpectedId1, actualId1);
            Assert.AreEqual(ExpectedId2, actualId2);

        }
    }    
}