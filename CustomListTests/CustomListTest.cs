using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_OneNumber_ReturnNumber()
        {
            //Arrange
            int expected = 16;
            CustomList<int> list = new CustomList<int>();

            //Act
            list.Add(16);

            // Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void 
    }
}
