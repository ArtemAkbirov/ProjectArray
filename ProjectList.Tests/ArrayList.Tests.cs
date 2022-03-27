using NUnit.Framework;
using System.Collections;
using ProjectList.Tests.ArrayListTestsSources;
using System;
using ProjectList.Tests.ArrayListNegativeTestsSources;
using static ProjectList.Tests.ArrayListNegativeTestsSources.DeleteLastNNumbersNegativeTestSource_WhenLengthLessThanN;

namespace ProjectList.Tests
{
    public class Tests
    {
        [TestCaseSource(typeof(DeleteAllByValueTestSource))]
        public void DeleteAllByValueTest(int value, ArrayList list, ArrayList expectedList, int expectedNumber)
        {
            int actualNumber = list.DeleteAllByValue(value);

            ArrayList actualList = list;

            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int value, ArrayList list, ArrayList expectedList)
        {
            list.AddLast(value);
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(AddStartTestSource))]
        public void AddStartTest(int value, ArrayList list, ArrayList expectedList)
        {
            list.AddStart(value);
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(AddIndexTestSource))]
        public void AddIndexTest(int Index, int value, ArrayList list, ArrayList expectedList)
        {
            list.AddIndex(value, Index);
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(AddIndexNegativeTestSource))]
        public void AddByIndexTest_WhenIndexOutOfLength_ShouldThrowException(ArrayList actuallist, int value, int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.AddIndex(index, value));
        }
        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(ArrayList list, ArrayList expectedList)
        {
            list.DeleteLast();
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(DeleteStartTestSource))]
        public void DeleteStartTest(ArrayList list, ArrayList expectedList)
        {
            list.DeleteStart();
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(DeleteStartNegativeTestSource))]
        public void DeleteStartTestWhenIndexOutOfLength_ShouldThrowException(ArrayList actuallist,  int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.DeleteStart(index));
        }
        [TestCaseSource(typeof(DeleteIndexTestSource))]
        public void DeleteIndexTest(int Index, ArrayList list, ArrayList expectedList)
        {
            list.DeleteIndex(Index);
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(DeleteIndexNegativeTestSource))]
        public void DeleteIndexTestWhenIndexOutOfLength_ShouldThrowException(ArrayList actuallist, int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.DeleteIndex(index));
        }
        [TestCaseSource(typeof(DeleteLastNNumbersTestSource))]
        public void DeleteLastNNumbersTest(int value, ArrayList list, ArrayList expectedList)
        {
            list.DeleteLastNNumbers(value);
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(DeleteLastNNumbersNegativeTestSource_WhenLengthLessThanN))]
        public void DeleteLastNNumbersWhenLenghtLessThanN(ArrayList actuallist, int n)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteLastNNumbers(n));
        }
        [TestCaseSource(typeof(DeleteLastNNumbersNegativeTestSource_WhenNLessThanZero))]
        public void DeleteLastNNumbersWhenNLessThanZero(ArrayList actuallist, int n)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteLastNNumbers(n));
        }
        [TestCaseSource(typeof(DeleteStartNNumbersTestSource))]
        public void DeleteStartNNumbersTest(int value, ArrayList list, ArrayList expectedList)
        {
            list.DeleteStartNNumbers(value);
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(DeleteStartNNumbersNegativeTestSource_WhenLengthLessThanN))]
        public void DeleteStartNNumbersWhenLenghtLessThanN(ArrayList actuallist, int n)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteStartNNumbers(n));
        }
        [TestCaseSource(typeof(DeleteStartNNumbersNegativeTestSource_WhenNLessThanZero))]
        public void DeleteStartNNumbersWhenNLessThanZero(ArrayList actuallist, int n)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteStartNNumbers(n));
        }
        [TestCaseSource(typeof(DeleteNElementsTestSource))]
        public void DeleteNElementsTest(int n, int index, ArrayList list, ArrayList expectedList)
        {
            list.DeleteStartNNumbers(n, index);
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(DeleteNElementsNegativeTestSource_WhenIndexLessThanZeroOrMoreThanLenght))]
        public void DeleteNElementsWhenIndexLessThanZeroOrMoreThanLenght(ArrayList actuallist, int n, int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.DeleteNElements(n, index));
        }
        [TestCaseSource(typeof(DeleteNElementsNegativeTestSource_WhenNLessThanZeroOrMoreThanLength))]
        public void DeleteNElementsWhenNLessThanZeroOrMoreThanLength(ArrayList actuallist, int n, int index)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteNElements(n, index));
        }
        [TestCaseSource(typeof(FindFirstIndexValueTestSource))]
        public void FindFirstIndexValueTest(int value, int expected, ArrayList list)
        {
            int actual = list.FindFirstIndexValue(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(ChangeIndexTestSource))]
        public void ChangeIndexTest(int index, int value, ArrayList list, ArrayList expectedList)
        {
            list.ChangeIndex(value, index);
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(ArrayList list, ArrayList expectedList)
        {
            list.Reverse();
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(FindMaxElementTestSource))]
        public void FindMaxElementTest(ArrayList list, ArrayList expectedList, int expectedNumber)
        {
            int actualNumber = list.FindMaxElement();
            Assert.AreEqual(expectedList, list);
            Assert.AreEqual(actualNumber, expectedNumber);
        }
        [TestCaseSource(typeof(FindMinElementTestSource))]
        public void FindMinElementTest(ArrayList list, ArrayList expectedList, int expectedNumber)
        {
            int actualNumber = list.FindMinElement();
            Assert.AreEqual(expectedList, list);
            Assert.AreEqual(actualNumber, expectedNumber);
        }
        [TestCaseSource(typeof(FindIndexMaxElementTestSource))]
        public void FindIndexMaxElementTest(ArrayList list, ArrayList expectedList, int expectedIndex)
        {
            int actualIndex = list.FindIndexMaxElement();
            Assert.AreEqual(expectedList, list);
            Assert.AreEqual(actualIndex, expectedIndex);
        }
        [TestCaseSource(typeof(FindIndexMinElementTestSource))]
        public void FindIndexMinElementTest(ArrayList list, ArrayList expectedList, int expectedIndex)
        {
            int actualIndex = list.FindIndexMinElement();
            Assert.AreEqual(expectedList, list);
            Assert.AreEqual(actualIndex, expectedIndex);
        }
        [TestCaseSource(typeof(SortIncreaseTestSource))]
        public void SortIncreaseTest(ArrayList list, ArrayList expectedList)
        {
            list.SortIncrease();
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(SortDescendingTestSource))]
        public void SortDescendingTest(ArrayList list, ArrayList expectedList)
        {
            list.SortDescending();
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(DeleteFirstValueTestSource))]
        public void DeleteFirstValueTest(int value, ArrayList list, ArrayList expectedList, int expectedNumber)
        {
            int actualNumber = list.DeleteFirstValue(value);
            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(expectedList, list);
        }

    }
}