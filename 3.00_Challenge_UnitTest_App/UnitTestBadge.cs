using Badge_Repository_App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _3._00_Challenge_UnitTest_App
{
    [TestClass]
    public class UnitTestBadge
    {
        [TestMethod]
        public void TestMethod1_DeleteDoor()
        {
            //Arrange
            Badge_Repository repo = new Badge_Repository();
            List<string> iDOne = new List<string> { "A22", "A23", "A42" };
            repo.AddEntry(10101, iDOne);
            repo.AddDoor(10101, "A44");
            string firstDoor = "A22";

            //Act
            int beforeCount = iDOne.Count;
            repo.DeleteDoor(10101, firstDoor);
            int actual = iDOne.Count;
            int expected = beforeCount - 1;

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void TestMethod2_ReturnDoorSet()
        {
            //Arrange
            Badge_Repository repo = new Badge_Repository();
            List<string> iDOne = new List<string> { "A22", "A23", "A42" };
            repo.AddEntry(10101, iDOne);

            //Act
            List<string> returnedStringList = repo.ReturnDoorSet(10101);
            
            //Assert
            Assert.AreEqual(returnedStringList, iDOne);
           
        }
        [TestMethod]
        public void TestMethod3_ReturnDoors()
        {
            //Arrange
            Badge_Repository repo = new Badge_Repository();
            List<string> iDOne = new List<string> { "A22", "A23", "A42" };
            repo.AddEntry(10101, iDOne);

            //Act
            List<string> returnedStringList = repo.ReturnDoors();

            //Assert
            Assert.IsNotNull(returnedStringList);
        }

        [TestMethod]
        public void TestMethod4_ReturnBadges()
        {
            //Arrange
            Badge_Repository repo = new Badge_Repository();
            List<string> iDOne = new List<string> { "A22", "A23", "A42" };
            repo.AddEntry(10101, iDOne);

            //Act
            List<string> returnedStringList = repo.ReturnBadges();
          
            //Assert
            Assert.IsNotNull(returnedStringList);
        }
    }
}
