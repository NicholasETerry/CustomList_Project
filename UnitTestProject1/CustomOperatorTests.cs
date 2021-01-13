using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomOperatorTests
    {
        [TestMethod]
        public void CustomOperatorMinus_TwoIntLists_ResultEquals70()
        {
            //ARRANGE
            CustomList<int> ListOne = new CustomList<int>() {20,50,70};
            CustomList<int> ListTwo = new CustomList<int>() {20,50,80};
            CustomList<int> Result = new CustomList<int>();
            int expectedResult = 70;
            int actualResult;
            //ACT
            Result = ListOne - ListTwo;
            actualResult = Result[0];
            //ASSERT
            CollectionAssert.Equals(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomOperatorMinus_TwoStringLists_ResultEqualsDev()
        {
            //ARRANGE
            CustomList<string> ListOne = new CustomList<string>() { "Dev", "Code", "Camp" };
            CustomList<string> ListTwo = new CustomList<string>() { "Code", "Camp" };
            CustomList<string> Result = new CustomList<string>();
            string expectedResult = "Dev";
            string actualResult;
            //ACT
            Result = ListOne - ListTwo;
            actualResult = Result[0];
            //ASSERT
            CollectionAssert.Equals(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomOperatorMinus_TwoStringListsWhereAllItemsMatch_NoItemsInList()
        {
            //ARRANGE
            CustomList<string> ListOne = new CustomList<string>() { "Dev", "Code", "Camp" };
            CustomList<string> ListTwo = new CustomList<string>() { "Dev", "Code", "Camp" };
            CustomList<string> Result = new CustomList<string>();
            string expectedResult = default ;
            string actualResult;
            //ACT
            Result = ListOne - ListTwo;
            actualResult = Result[0];
            //ASSERT
            CollectionAssert.Equals(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomOperatorPlus_TwoIntLists_Result123456()
        {
            //ARRANGE
            CustomList<int> ListOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> ListTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> Result = new CustomList<int>();
            CustomList<int> expectedResult = new CustomList<int>(){ 1,2,3,4,5,6};
            CustomList<int> actualResult;
            //ACT
            Result = ListOne + ListTwo;
            actualResult = Result;

            //ASSERT
            CollectionAssert.Equals(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomOperatorPlus_TwoStringLists_ResultDevCodeCampIsTheBest()
        {
            //ARRANGE
            CustomList<string> ListOne = new CustomList<string>() { "Dev", " Code", " Camp" };
            CustomList<string> ListTwo = new CustomList<string>() { " Is", " The", " Best" };
            CustomList<string> Result = new CustomList<string>();
            CustomList<string> expectedResult = new CustomList<string>() { "Dev", " Code", " Camp", " Is", " The", " Best" };
            CustomList<string> actualResult;
            //ACT
            Result = ListOne - ListTwo;
            actualResult = Result;
            //ASSERT
            CollectionAssert.Equals(expectedResult, actualResult);
        }
        [TestMethod]
        public void CustomOperatorPlus__TwoStringListsOfUnequalSize_ResultDevCodeCamp()
        {
            //ARRANGE
            CustomList<string> ListOne = new CustomList<string>() { "Dev" };
            CustomList<string> ListTwo = new CustomList<string>() { " Code", " Camp" };
            CustomList<string> Result = new CustomList<string>();
            CustomList<string> expectedResult = new CustomList<string>() { "Dev", " Code", " Camp" };
            CustomList<string> actualResult;
            //ACT
            Result = ListOne - ListTwo;
            actualResult = Result;
            //ASSERT
            CollectionAssert.Equals(expectedResult, actualResult);
        }
        [TestMethod]
        public void ToStringOverrideMethod_ListOfInts_StringOf123456()
        {
            //ARRANGE
            CustomList<int> ListOne = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            string expectedResult = "123456";
            string actualResult;
            //ACT
            actualResult = ListOne.ToString();
            //ASSERT
            CollectionAssert.Equals(expectedResult, actualResult);
        }
        [TestMethod]
        public void ToStringOverrideMethod_ListOfChars_StringOfabcdef()
        {
            //ARRANGE
            CustomList<string> ListOne = new CustomList<string>() { "a", "b", "c", "d", "e", "f" };
            string expectedResult = "abcdef";
            string actualResult;
            //ACT
            actualResult = ListOne.ToString();
            //ASSERT
            CollectionAssert.Equals(expectedResult, actualResult);
        }
    }
}
