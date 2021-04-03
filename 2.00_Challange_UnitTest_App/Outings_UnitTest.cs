using _4._00_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _4._00_Challange_UnitTest_App
{
    [TestClass]
    public class Outings_UnitTest
    {
        [TestMethod]
        public void TestMethod1_AddContentToList()
        {
            //Arrange
            CompanyOutings_Content content = new CompanyOutings_Content();
            CompanyOutings repo = new CompanyOutings();
            List<CompanyOutings_Content> localList = repo.ReturnEvents();

            //Act
            int beforeCount = localList.Count;
            repo.AddContentToList(content);
            int actual = localList.Count;
            int expected = beforeCount + 1;

            //Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void MyTestMethod2_ReturnSum()
        {
            //Arrange
            CompanyOutings_Content eventOne = new CompanyOutings_Content("Golf", 20, "03/23/2020", 72.84d, 1456.80d);
            CompanyOutings_Content eventTwo = new CompanyOutings_Content("Bowling", 34, "04/13/2020", 10.15d, 345.10d);
            CompanyOutings repo = new CompanyOutings();
            repo.AddContentToList(eventOne);
            repo.AddContentToList(eventTwo);
            double eventOneCost = 1456.80d;
            double eventTwoCost = 345.10d;

            //Act
            double expected = eventOneCost + eventTwoCost; 

            //Assert
            double actual = repo.ReturnSum();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyTestMethod3_ReturnGolf()
        {
            //Arrange
            CompanyOutings_Content eventOne = new CompanyOutings_Content("Golf", 20, "03/23/2020", 72.84d, 1456.80d);
            CompanyOutings_Content eventTwo = new CompanyOutings_Content("Golf", 15, "04 /30/2020", 66.92d, 1003.80d);
            CompanyOutings repo = new CompanyOutings();
            repo.AddContentToList(eventOne);
            repo.AddContentToList(eventTwo);
            double eventOneCost = 1456.80d;
            double eventTwoCost = 1003.80d;

            //Act
            double expected = eventOneCost + eventTwoCost;

            //Assert
            double actual = repo.ReturnGolfItemCost();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyTestMethod3_ReturnBowling()
        {
            //Arrange
            CompanyOutings_Content eventOne = new CompanyOutings_Content("Bowling", 34, "04/13/2020", 10.15d, 345.10d);
            CompanyOutings_Content eventTwo = new CompanyOutings_Content("Bowling", 41, "05/05/2020", 11.15d, 457.15d);
            CompanyOutings repo = new CompanyOutings();
            repo.AddContentToList(eventOne);
            repo.AddContentToList(eventTwo);
            double eventOneCost = 345.10d;
            double eventTwoCost = 457.15d;

            //Act
            double expected = eventOneCost + eventTwoCost;

            //Assert
            double actual = repo.ReturnBowlingItemCost();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyTestMethod3_ReturnAmusmentPark()
        {
            //Arrange
            CompanyOutings_Content eventOne = new CompanyOutings_Content("Amusement Park", 36, "04/27/2020", 99.11d, 3567.99d);
            CompanyOutings_Content eventTwo = new CompanyOutings_Content();
            CompanyOutings repo = new CompanyOutings();
            repo.AddContentToList(eventOne);
            repo.AddContentToList(eventTwo);
            double eventOneCost = 3567.99d;
            double eventTwoCost = 0d;

            //Act
            double expected = eventOneCost + eventTwoCost;

            //Assert
            double actual = repo.ReturnAmusementParkItemCost();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyTestMethod3_ReturnConcertItem()
        {
            //Arrange
            CompanyOutings_Content eventOne = new CompanyOutings_Content("Concert", 26, "05/29/2020", 55.00d, 1430.00d);
            CompanyOutings_Content eventTwo = new CompanyOutings_Content("Concert", 45, "06/15/2020", 45.00d, 2025.00d);
            CompanyOutings repo = new CompanyOutings();
            repo.AddContentToList(eventOne);
            repo.AddContentToList(eventTwo);
            double eventOneCost = 1430.00d;
            double eventTwoCost = 2025.00d;

            //Act
            double expected = eventOneCost + eventTwoCost;

            //Assert
            double actual = repo.ReturnConcertItemCost();
            Assert.AreEqual(expected, actual);
        }
    }
}
