using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class AddMethodStringTests
    {
        [TestMethod]
        public void AddMethod_AddFourStrings_StringsStoredInList()
        {
            //ARRANGE
            CustomList<string> newList = new CustomList<string>();
            string expectedResult = "This is a test.";
            string actualResult;
            StringBuilder builtString = new StringBuilder();
            //ACT
            newList.Add("This");
            newList.Add(" is");
            newList.Add(" a");
            newList.Add(" test.");

            foreach (var item in newList)
            {
                builtString.Append(item);
            }
            actualResult = builtString.ToString();
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddMethod_CapacityOfList_CapacityOfFour()
        {
            //ARRANGE
            CustomList<string> newList = new CustomList<string>();
            int expectedResult = 4;
            int actualResult;
            //ACT
            newList.Add("This");
            newList.Add(" is");
            newList.Add(" a");
            newList.Add(" test.");

            actualResult = newList.Count;
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddMethod_CountIncreaseWhenItemAdded_CountEqualsThree()
        {
            //ARRANGE
            CustomList<string> newList = new CustomList<string>() {"Count"," Equals"};
            int expectedResult = 3;
            int actualResult;
            //ACT
            newList.Add(" Three");

            actualResult = newList.Count;
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddMethod_AddFiveItems_CapacityIncreaseToEight()
        {
            CustomList<string> newList = new CustomList<string>();
            int expectedResult = 8;
            int actualResult;

            newList.Add("This");
            newList.Add(" is");
            newList.Add(" a");
            newList.Add(" test");
            newList.Add(" again.");

            actualResult = newList.Capacity;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddMethod_TestItemIndexLocationWhenCapacityIncreases_IndexValuesHold()
        {
            CustomList<string> newList = new CustomList<string>();
            string expectedResult = "This";
            string actualResult;

            newList.Add("This");
            newList.Add(" is");
            newList.Add(" a");
            newList.Add(" test");
            newList.Add(" again.");

            actualResult = newList[0];

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
