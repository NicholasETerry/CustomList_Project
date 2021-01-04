using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
using System.Collections.Generic;

namespace TestAddClass
{
    [TestClass]
    public class TestAddMethod<T>
    {
        [TestMethod]

        // As a developer, i want the ability to add an object to an instance of my custom-built list class by imitating the C# Add() method.
        //-----
        public void CustomAddMethod_IndexValueForAddedItem_ReturnFirstPositionInIndexValue(T testItem) // return index postion of item added - only adds one item to list
        {
            // ARRANGE
            CustomList<T> newCustomList = new CustomList<T>();
            T expectedResult = testItem;
            T actualResult;
            // ACT
            newCustomList.CustomAdd(testItem);
            actualResult = newCustomList.holdingArray[0];
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
