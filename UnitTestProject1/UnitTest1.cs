using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // As a developer, i want the ability to add an object to an instance of my custom-built list class by imitating the C# Add() method.
        //-----
        public int this[int index] // indexer
        {
            get
            {
                return newCustomList.holdingArray[0];
            }
            set
            {
                actualResult = holdingArray[index];
            }
        }
        [TestMethod]
        public void CustomAddMethod_IndexValueForAddedItem_ReturnFirstPositionInIndexValue() // return index postion of item added 
        {
            // ARRANGE
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 5;
            int value1 = 5;
            int actualResult;
            // ACT
            newCustomList.CustomAdd(value1);
            actualResult = newCustomList[0];

            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomAddMethod_CapacityOfListAtCreation_ReturnCapacityOfFour() //testing capacity when we first create a list - capacity should be 4
        {
            // ARRANGE
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 4;
            int actualResult = newCustomList.capacity; // Capacity will need to be created in CustomList

            // ACT
            // should just need two variables to determine if expected is the same as the capacity.
            // no logic needed in the ACT stage.

            //ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomAddMethod_CountIncrementsWhenItemAddedToList_CountIncreaseByOne() //checking to see if count increments
        {
            // ARRANGE
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 1;
            int actualResult; // Count needs to be created in CustomList

            // ACT
            newCustomList.CustomAdd(1);
            actualResult = newCustomList.Count;

            // ARRANGE
            Assert.AreEqual(expectedResult, actualResult);
        }

        
        [TestMethod]
        public void CustomAddMethod_AddFiveItems_CapacityIncreaseToEight() //testing capacity when we add more than 4 items, capacity should be 8
        {
            //ARRANGE
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 8;
            //int testFill = 1;
            int actualResult;

            //ACT
            //for (int i = 0; i < newCustomList.holdingArray.Length/* will result in i being larger then array*/; i++) // need indexer due to protection level
            //{
            //    newCustomList.holdingArray[i] = testFill;
            //    testFill++;
            //}
            newCustomList.CustomAdd(1);
            newCustomList.CustomAdd(2);
            newCustomList.CustomAdd(3);
            newCustomList.CustomAdd(4);
            newCustomList.CustomAdd(5);


            actualResult = newCustomList.Capacity;
            //ARRANGE
            Assert.AreEqual(expectedResult, actualResult);
            
        }
        [TestMethod]
        public void CustomAddMethod_TestItemIndexLocationWhenCapacityIncreases_IndexValuesHold() //when capacity increases to 8 , lets make sure that one of the values 
        {                                                                                        // is still in the right index
                                                                                                 //ARRANGE
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 1; 
            int actualResult;

            //ACT
            newCustomList.CustomAdd(1);
            newCustomList.CustomAdd(2);
            newCustomList.CustomAdd(3);
            newCustomList.CustomAdd(4);
            newCustomList.CustomAdd(5);


            actualResult = newCustomList.holdingArray[0];
            //ARRANGE
            Assert.AreEqual(expectedResult, actualResult);
            

            //CustomList<int> newCustomList = new CustomList<int>();
            //int[] beginningIndexes = new int[4];
            //int[] endingIndexes = new int[8];
            //int testFill = 1;
            //int expectedResult = 4;
            //int actualResult = 0;

            ////ACT
            //for (int i = 0; i < newCustomList.holdingArray.Length /* will result in i being larger then array*/; i++) // need indexer due to protection level
            //{
            //    newCustomList.holdingArray[i] = testFill;
            //    testFill++;
            //    if(i < 4)
            //    {
            //        beginningIndexes[i] = newCustomList.holdingArray[i];
            //    }
            //    endingIndexes[i] = newCustomList.holdingArray[i];
            //}
            //for (int i = 0; i < beginningIndexes.Length - 1; i++)
            //{
            //    if(beginningIndexes[i] == endingIndexes[i])
            //    {
            //        actualResult++;
            //    }
            //}
            //ARRANGE
            //Assert.AreEqual(expectedResult, actualResult);
        }
        

    }
}
