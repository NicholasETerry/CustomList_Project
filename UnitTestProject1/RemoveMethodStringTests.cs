using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace UnitTestProject1
{
    [TestClass]
    public class RemoveMethodStringTests
    {
        [TestMethod]
        public void RemoveMethod_RemoveFirstAccurenceInList_RemoveValueOfOne()
        {
            CustomList<string> newCustomList = new CustomList<string>();
            string expectedResult = " Code";
            string actualResult;

            newCustomList.Add("Dev");
            newCustomList.Add(" Code");
            newCustomList.Remove("Dev");

            actualResult = newCustomList[0];

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void RemoveMethod__UpdateCountAfterRemove_CountEqaulsFour()
        {
            CustomList<string> newCustomList = new CustomList<string>();
            int expectedResult = 4;
            int actualResult;

            newCustomList.Add("Dev");
            newCustomList.Add(" Code");
            newCustomList.Add(" Camps");
            newCustomList.Add(" The");
            newCustomList.Add(" Best");
            newCustomList.Remove("Dev");

            actualResult = newCustomList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void RemoveMethod__UpdateCapacityAfterRemove_CapacityEqaulsFour()
        {
            CustomList<string> newCustomList = new CustomList<string>();
            int expectedResult = 4;
            int actualResult;

            newCustomList.Add("Dev");
            newCustomList.Add(" Code");
            newCustomList.Add(" Camps");
            newCustomList.Add(" The");
            newCustomList.Add(" Best");
            newCustomList.Remove("Dev");
            newCustomList.Trim();

            actualResult = newCustomList.Capacity;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void RemoveMethod_IsThereAnItemToRemove_DevCodeCampsThe()
        {
            CustomList<string> newCustomList = new CustomList<string>();
            bool expectedResult = true;
            bool actualResult;

            newCustomList.Add("Dev");
            newCustomList.Add(" Code");
            newCustomList.Add(" Camps");
            newCustomList.Add(" The");
            newCustomList.Add(" Best");

            actualResult = newCustomList.Remove(" Best");

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
