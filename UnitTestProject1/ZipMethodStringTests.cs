using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace UnitTestProject1
{
    [TestClass]
    public class ZipMethodStringTests
    {
        [TestMethod]
        public void Zip_MergeTwoObjects_DevCodeCampIsTheBest()
        {
            // ARRANGE
            CustomList<string> oddList = new CustomList<string>();
            oddList.Add("Dev");
            oddList.Add(" Camp");
            oddList.Add(" The");
            CustomList<string> evenList = new CustomList<string>();
            evenList.Add(" Code");
            evenList.Add(" Is");
            evenList.Add(" Best.");
            string expectedResult = "Dev Code Camp Is The Best.";
            string actualResult;
            // ACT
            actualResult = oddList.Zip(evenList).ToString();
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Zip_MergeTwoObjectsOfUnevenSize_DevCodeCampIsThe()
        {
            // ARRANGE
            CustomList<string> oddList = new CustomList<string>();
            oddList.Add("Dev");
            oddList.Add(" Camp");
            oddList.Add(" The");
            CustomList<string> evenList = new CustomList<string>();
            evenList.Add(" Code");
            evenList.Add(" Is");
            string expectedResult = "Dev Code Camp Is The";
            string actualResult;
            // ACT
            actualResult = oddList.Zip(evenList).ToString();
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Zip_MergeTwoObjectsOfUnevenSize_CodeCampIsTheBest()
        {
            // ARRANGE
            CustomList<string> oddList = new CustomList<string>();
            oddList.Add(" Camp");
            oddList.Add(" The");
            CustomList<string> evenList = new CustomList<string>();
            evenList.Add(" Code");
            evenList.Add(" Is");
            evenList.Add(" Best.");
            string expectedResult = " Camp Code The Is Best.";
            string actualResult;
            // ACT
            actualResult = oddList.Zip(evenList).ToString();
            // ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
