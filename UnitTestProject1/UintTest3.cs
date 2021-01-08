using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for UintTest3
    /// </summary>
    [TestClass]
    public class UintTest3
    {
        [TestMethod]
        public void Zip_MergeTwoObjects_123456()
        {
            // ARRANGE
            CustomList<int> oddList = new CustomList<int>();
            oddList.CustomAdd(1);
            oddList.CustomAdd(3);
            oddList.CustomAdd(5);
            CustomList<int> evenList = new CustomList<int>();
            evenList.CustomAdd(2);
            evenList.CustomAdd(4);
            evenList.CustomAdd(6);
            string expectedResult = "123456";
            string actualResult;


            // ACT

            actualResult = oddList.Zip(evenList).ToString();
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
