using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CustomListClass;

namespace TestAddClass
{
    [TestClass]
    public class TestAddMethod<T>
    {

        // As a developer, i want the ability to add an object to an instance of my custom-built list class by imitating the C# Add() method.
        //-----
        [TestMethod]
        public void CustomAddMethod_IndexValueForAddedItem_ReturnFirstPositionInIndexValue() // return index postion of item added - only adds one item to list
        {
            // ARRANGE
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 5;
            int actualResult;
            int value1 = 5;
            // ACT
            newCustomList.CustomAdd(value1);
            actualResult = newCustomList[0]; // indexer
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SuperTestMethod()
        {
            int i = 0;
            int j = 0;
            Assert.AreEqual(i, j);
        }
        [TestMethod]
        public void SuperTestMethodTwo()
        {
            int i = 0;
            int j = 0;
            Assert.AreEqual(i, j);
        }
    }
}
