﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomListClass;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        // As a developer, i want the ability to remove an object from an instance of my custom-built list class by imitating the C# Remove() method.
        //-----
        
        [TestMethod]
        public void CustomRemoveMethod_RemoveFirstAccurenceInList_RemoveValueOfOne() // 1. remove item and check that item was removed
        {
            // ARRANGE
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 5;
            int actualResult;
            // ACT
            newCustomList.CustomAdd(1);
            newCustomList.CustomAdd(5);
            newCustomList.CustomRemove(1);
            actualResult = newCustomList[0];
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomRemoveMethod_CheckIndexValuesAfterItemRemoved_IndexOneEqualIndexZero() // 2. remove item and make sure that other items in list indexes change
        {
            // ARRANGE
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 5;
            int actualResult;
            // ACT
            newCustomList.CustomAdd(1);
            newCustomList.CustomAdd(5);
            newCustomList.CustomRemove(1);
            actualResult = newCustomList[0];
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomRemoveMethod__UpdateCountAfterRemove_CountEqaulsFour() // 3. if list count is 5 and item is removed, count should go to 4
        {
            // ARRANGE
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 4;
            int actualResult;
            // ACT
            newCustomList.CustomAdd(1);
            newCustomList.CustomAdd(5);
            newCustomList.CustomAdd(15);
            newCustomList.CustomAdd(22);
            newCustomList.CustomAdd(45);
            newCustomList.CustomRemove(1);
            actualResult = newCustomList.Count;
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomRemoveMethod__UpdateCapacityAfterRemove_CapacityEqaulsFour() // 4. make sure capacity changes if not needed after removing item
        {
            // ARRANGE
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 4;
            int actualResult;
            // ACT
            newCustomList.CustomAdd(1);
            newCustomList.CustomAdd(5);
            newCustomList.CustomAdd(15);
            newCustomList.CustomAdd(22);
            newCustomList.CustomAdd(45);
            newCustomList.CustomRemove(1);
            actualResult = newCustomList.Capacity;
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomRemoveMethod_IsThereAnItemToRemove_ReturnThree() // 5. check to see if there is an item to remove from list
        {
            // ARRANGE
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 3;
            int actualResult;
            // ACT
            newCustomList.CustomAdd(5);
            newCustomList.CustomAdd(15);
            newCustomList.CustomAdd(22);
            newCustomList.CustomAdd(45);
            newCustomList.CustomRemove(5);
            actualResult = newCustomList.Count;
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
