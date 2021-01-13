using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomListClass;

namespace UnitTestProject1
{
    [TestClass]
    public class RemoveMethodIntTests
    {
        [TestMethod]
        public void RemoveMethod_RemoveFirstAccurenceInList_RemoveValueOfOne()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 5;
            int actualResult;

            newCustomList.Add(1);
            newCustomList.Add(5);
            newCustomList.Remove(1);

            actualResult = newCustomList[0];
 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void RemoveMethod_CheckIndexValuesAfterItemRemoved_IndexOneEqualIndexZero()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 5;
            int actualResult;

            newCustomList.Add(1);
            newCustomList.Add(5);
            newCustomList.Remove(1);

            actualResult = newCustomList[0];

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void RemoveMethod__UpdateCountAfterRemove_CountEqaulsFour()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 4;
            int actualResult;

            newCustomList.Add(1);
            newCustomList.Add(5);
            newCustomList.Add(15);
            newCustomList.Add(22);
            newCustomList.Add(45);
            newCustomList.Remove(1);

            actualResult = newCustomList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void RemoveMethod__UpdateCapacityAfterRemove_CapacityEqaulsFour()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 4;
            int actualResult;

            newCustomList.Add(1);
            newCustomList.Add(5);
            newCustomList.Add(15);
            newCustomList.Add(22);
            newCustomList.Add(45);
            newCustomList.Remove(1);
            newCustomList.Trim();

            actualResult = newCustomList.Capacity;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void RemoveMethod_IsThereAnItemToRemove_ReturnTrue()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            bool expectedResult = true;
            bool actualResult;

            newCustomList.Add(5);
            newCustomList.Add(15);
            newCustomList.Add(22);
            newCustomList.Add(45);
            actualResult = newCustomList.Remove(5);  

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
