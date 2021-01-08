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
    public class UnitTest2
    {
        [TestMethod]
        public void CustomRemoveMethod_RemoveFirstAccurenceInList_RemoveValueOfOne()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 5;
            int actualResult;

            newCustomList.CustomAdd(1);
            newCustomList.CustomAdd(5);
            newCustomList.CustomRemove(1);

            actualResult = newCustomList[0];
 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomRemoveMethod_CheckIndexValuesAfterItemRemoved_IndexOneEqualIndexZero()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 5;
            int actualResult;

            newCustomList.CustomAdd(1);
            newCustomList.CustomAdd(5);
            newCustomList.CustomRemove(1);

            actualResult = newCustomList[0];

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomRemoveMethod__UpdateCountAfterRemove_CountEqaulsFour()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 4;
            int actualResult;

            newCustomList.CustomAdd(1);
            newCustomList.CustomAdd(5);
            newCustomList.CustomAdd(15);
            newCustomList.CustomAdd(22);
            newCustomList.CustomAdd(45);
            newCustomList.CustomRemove(1);

            actualResult = newCustomList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomRemoveMethod__UpdateCapacityAfterRemove_CapacityEqaulsFour()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            int expectedResult = 4;
            int actualResult;

            newCustomList.CustomAdd(1);
            newCustomList.CustomAdd(5);
            newCustomList.CustomAdd(15);
            newCustomList.CustomAdd(22);
            newCustomList.CustomAdd(45);
            newCustomList.CustomRemove(1);
            newCustomList.Trim();

            actualResult = newCustomList.Capacity;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomRemoveMethod_IsThereAnItemToRemove_ReturnTrue()
        {
            CustomList<int> newCustomList = new CustomList<int>();
            bool expectedResult = true;
            bool actualResult;

            newCustomList.CustomAdd(5);
            newCustomList.CustomAdd(15);
            newCustomList.CustomAdd(22);
            newCustomList.CustomAdd(45);
            actualResult = newCustomList.CustomRemove(5);  

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
