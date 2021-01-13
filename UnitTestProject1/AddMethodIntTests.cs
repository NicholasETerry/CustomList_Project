using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace UnitTestProject1
{
    [TestClass]
    public class AddMethodIntTests
    {
        [TestMethod]
        public void AddMethod_IndexValueForAddedItem_ReturnFirstPositionInIndexValue()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 5;
            int value1 = 5;
            int actualResult;
            
            newCustomList.Add(value1);
            actualResult = newCustomList[0];

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddMethod_CapacityOfListAtCreation_ReturnCapacityOfFour()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 4;
            int actualResult = newCustomList.Capacity; 

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddMethod_CountIncrementsWhenItemAddedToList_CountIncreaseByOne()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 1;
            int actualResult;

            newCustomList.Add(1);
            actualResult = newCustomList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }     
        [TestMethod]
        public void AddMethod_AddFiveItems_CapacityIncreaseToEight()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 8;
            int actualResult;

            newCustomList.Add(1);
            newCustomList.Add(2);
            newCustomList.Add(3);
            newCustomList.Add(4);
            newCustomList.Add(5);

            actualResult = newCustomList.Capacity;

            Assert.AreEqual(expectedResult, actualResult);           
        }
        [TestMethod]
        public void AddMethod_TestItemIndexLocationWhenCapacityIncreases_IndexValuesHold() 
        {                                                                                        
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 1; 
            int actualResult;

            newCustomList.Add(1);
            newCustomList.Add(2);
            newCustomList.Add(3);
            newCustomList.Add(4);
            newCustomList.Add(5);

            actualResult = newCustomList[0];

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddMethod_OutOfRangeTest_ThrowException()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int actualResult;

            actualResult = newCustomList[16];
            newCustomList.Add(1);
            newCustomList.Add(2);
            newCustomList.Add(3);
            newCustomList.Add(4);
            newCustomList.Add(5);


        }

    }
}
