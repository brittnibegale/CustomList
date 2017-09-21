﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
//using System.Collections.IEnumerable;

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
        public void Add_OneString_ReturnString()
        {
            //Arrange
            string expected = "hi";
            CustomList<string> list = new CustomList<string>();

            //Act
            list.Add("hi");

            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Add_TwoNumbers_ReturnNumbers()
        {
            //Arrange
            int expected = 2;
            CustomList<int> list = new CustomList<int>();
            list.Add(1);

            //Act 
            list.Add(2);

            //Assert
            Assert.AreEqual(expected, list[1]);

        }
        [TestMethod]
        public void Add_OneDouble_ReturnDouble()
        {
            //Arrange
            double expected = 1.01;
            CustomList<double> list = new CustomList<double>();

            //Act 
            list.Add(1.01);

            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Add_ThirteenNumbers_ReturnSixIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int value8 = 8;
            int value9 = 9;
            int value10 = 10;
            int value11 = 11;
            int value12 = 12;
            int value13 = 13;

            //Act
            list.Add(value);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Add(value6);
            list.Add(value7);
            list.Add(value8);
            list.Add(value9);
            list.Add(value10);
            list.Add(value11);
            list.Add(value12);
            list.Add(value13);

            //Assert
            Assert.AreEqual(value7, list[6]);
        } 

        //[TestMethod]
        //public void Check_Exception_ReturnException()
        //{
        //    //Arrange
        //    string expected = "Not a whole number" ;
        //    CustomList<int> list = new CustomList<int>();

        //    //Act
        //    list.Add("hi");

        //    //Assert
        //    Assert.AreEqual(expected, e);

        //}
       
            
        [TestMethod]
        public void Remove_OneInt_ReturnIndexOfList()
        {
            //Arrange
            int expected = 1;
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);

            //Act 
            list.Remove(list[1]);

            //Assert
            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void Remove_UnpopulatedList_ReturnExecption()
        {
            //Arrange


            //InvaildOperationException
        }

        public void Remove_MultipulInt_ReturnIndex()
        {
            //Arrange
            CustomList<double> list = new CustomList<double>();
            double value = 1;
            double value1 = 2;
            double value2 = 3;
            double value3 = 4;
            double value4 = 5;
            double value5 = 6;
            double value6 = 7;
            double value7 = 8;
            double value8 = 9;
            double value9 = 10;
            double value10 = 11;
            double value11 = 12;
            double value12 = 13;
           
            //Act
            list.Add(value);
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Add(value6);
            list.Add(value7);
            list.Add(value8);
            list.Add(value9);
            list.Add(value10);
            list.Add(value11);
            list.Add(value12);
            list.Remove(value4);
            list.Remove(value6);

            //Assert
            Assert.AreEqual(value5, list[4]);
        }

        [TestMethod]
        public void Remove_String_ReturnIndex()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "hi";
            string input = "there";
            list.Add(expected);
            list.Add(input);

            //Act
            list.Remove(input);

            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Remove_TwoStrings_ReturnIndex()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "er";
            list.Add("keep");
            list.Add("er");
            list.Add("movin'");

            //Act
            list.Remove(list[0]);
            list.Remove(list[2]);

            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        //
        //public void Iteration_String_ReturnIteration()
        //{
        //    CustomList<int> list = new CustomList<int>();
        //    list.Add(1);
        //    list.Add(2);

        //    foreach(int number in list)
        //    {
        //        System.Console.Write(number + " ");
        //    }
        //}

        [TestMethod]
        public void Remove_CountOfList_ReturnCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;
            int value = 1;
            int value2 = 2;

            //Act
            list.Add(value);
            list.Add(value2);
            list.Remove(value);
            list.Count(list);

            //Assert
            Assert.AreEqual(expected, list.count);
        }

        [TestMethod]
        public void Remove_CapacityOfList_ReturnCapacity()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 8;
            int value = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;

            //Act
            list.Add(value);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Remove(value3);
            list.Count(list);//Create properties so they are accessible
            list.Capacity();

            //Assert
            Assert.AreEqual(expected, list.capacity);
        }

        [TestMethod]
        public void Convert_IntListString_ReturnString()
        {
            CustomList<int> list = new CustomList<int>();
            string expected = "1 2";
            int value = 1;
            int value2 = 2;

            list.Add(value);
            list.Add(value2);
            string words = list.ToString();

            Assert.AreEqual(expected, words);
        }
        [TestMethod]
        public void Convert_StringListString_ReturnString()
        {
            CustomList<string> list = new CustomList<string>();
            string expected = "hi there";
            string value = "hi";
            string value2 = "there";

            list.Add(value);
            list.Add(value2);
            string words = list.ToString();

            Assert.AreEqual(expected, words);
        }
        [TestMethod]
        public void Convert_DoubleListString_ReturnString()
        {
            CustomList<double> list = new CustomList<double>();
            string expected = "2.2 3.4 2.3";
            double value = 2.2;
            double value1 = 3.4;
            double value2 = 2.3;

            list.Add(value);
            list.Add(value1);
            list.Add(value2);
            string words = list.ToString();

            Assert.AreEqual(expected, words);
        }

        public void Check_StringToCount_ReturnCount()
        {
            CustomList<double> list = new CustomList<double>();
            int expected = 1;
            double value = 2.2;
            double value1 = 3.4;
            double value2 = 2.3;

            list.Add(value);
            list.Add(value1);
            list.Add(value2);
            string words = list.ToString();
            list.Count(list);

            Assert.AreEqual(expected, list.count);

        }


    }
}
