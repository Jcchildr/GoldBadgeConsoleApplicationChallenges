using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Repository_App;
using System.Collections.Generic;

namespace UnitTestCafe_App
{
    [TestClass]
    public class UnitTestCafe
    {

        [TestInitialize]
        public void Arrange()
        {
            CafeMenuContent content = new CafeMenuContent();
            CafeMenuContent_Repository repo = new CafeMenuContent_Repository();
        }
        [TestMethod]
        public void TestMethod1_AddContent()
        {
            //Arrange
            CafeMenuContent content = new CafeMenuContent();
            CafeMenuContent_Repository repo = new CafeMenuContent_Repository();
            List<CafeMenuContent> localList = repo.ReturnMenu();

            //Act
            int beforeCount = localList.Count;
            repo.AddContentToList(content);
            int actual = localList.Count;
            int expected = beforeCount + 1;

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2_RemoveMenuItem()
        {

            //Arrange
            CafeMenuContent_Repository repo = new CafeMenuContent_Repository();
            CafeMenuContent oldContent = new CafeMenuContent(1, "The Morning Glory", "A breakfest burger to start your day off right.", "Bacon, egg, hash brown, lettuce, tomato, red onion, tomato relish & tarragon mayonnaise.", 10.95);
            repo.AddContentToList(oldContent);
            string mealName = "The Morning Glory";

            //Act
            bool remove = repo.RemoveMenuItem(mealName);

            //Assert
            Assert.IsTrue(remove);
        }
    }
}
