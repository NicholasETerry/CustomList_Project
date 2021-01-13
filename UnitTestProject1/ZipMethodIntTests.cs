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
    public class ZipMethodIntTests
    {
        [TestMethod]
        public void Zip_MergeTwoObjects_123456()
        {
            // ARRANGE
            CustomList<int> oddList = new CustomList<int>();
            oddList.Add(1);
            oddList.Add(3);
            oddList.Add(5);
            CustomList<int> evenList = new CustomList<int>();
            evenList.Add(2);
            evenList.Add(4);
            evenList.Add(6);
            string expectedResult = "123456";
            string actualResult;


            // ACT

            actualResult = oddList.Zip(evenList).ToString();
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Zip_MergeTwoObjectsOfUnevenSize_12345()
        {
            // ARRANGE
            CustomList<int> oddList = new CustomList<int>();
            oddList.Add(1);
            oddList.Add(3);
            oddList.Add(5);
            CustomList<int> evenList = new CustomList<int>();
            evenList.Add(2);
            evenList.Add(4);
            string expectedResult = "12345";
            string actualResult;


            // ACT

            actualResult = oddList.Zip(evenList).ToString();
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Zip_MergeTwoObjectsOfUnevenSize_32546()
        {
            // ARRANGE
            CustomList<int> oddList = new CustomList<int>();
            oddList.Add(3);
            oddList.Add(5);
            CustomList<int> evenList = new CustomList<int>();
            evenList.Add(2);
            evenList.Add(4);
            evenList.Add(6);
            string expectedResult = "32546";
            string actualResult;


            // ACT

            actualResult = oddList.Zip(evenList).ToString();
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
