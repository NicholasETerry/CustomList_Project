using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomAddMethod_IndexValueForAddedItem_ReturnFirstPositionInIndexValue()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 5;
            int value1 = 5;
            int actualResult;
            
            newCustomList.CustomAdd(value1);
            actualResult = newCustomList[0];

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomAddMethod_CapacityOfListAtCreation_ReturnCapacityOfFour()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 4;
            int actualResult = newCustomList.Capacity; 

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomAddMethod_CountIncrementsWhenItemAddedToList_CountIncreaseByOne()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 1;
            int actualResult;

            newCustomList.CustomAdd(1);
            actualResult = newCustomList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }     
        [TestMethod]
        public void CustomAddMethod_AddFiveItems_CapacityIncreaseToEight()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 8;
            int actualResult;

            newCustomList.CustomAdd(1);
            newCustomList.CustomAdd(2);
            newCustomList.CustomAdd(3);
            newCustomList.CustomAdd(4);
            newCustomList.CustomAdd(5);

            actualResult = newCustomList.Capacity;

            Assert.AreEqual(expectedResult, actualResult);           
        }
        [TestMethod]
        public void CustomAddMethod_TestItemIndexLocationWhenCapacityIncreases_IndexValuesHold() 
        {                                                                                        
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 1; 
            int actualResult;

            newCustomList.CustomAdd(1);
            newCustomList.CustomAdd(2);
            newCustomList.CustomAdd(3);
            newCustomList.CustomAdd(4);
            newCustomList.CustomAdd(5);

            actualResult = newCustomList[0];

            Assert.AreEqual(expectedResult, actualResult);
        }
        

    }
}
