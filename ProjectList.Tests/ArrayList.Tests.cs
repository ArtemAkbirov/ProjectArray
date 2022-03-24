using NUnit.Framework;
using System.Collections;
using ProjectList.Tests.ArrayListTestsSources;

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
        [TestCaseSource(typeof(DeleteIndexTestSource))]
        public void DeleteIndexTest(int Index, ArrayList list, ArrayList expectedList)
        {
            list.DeleteIndex(Index);
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(DeleteLastNNumbersTestSource))]
        public void DeleteLastNNumbersTest(int value, ArrayList list, ArrayList expectedList)
        {
            list.DeleteLastNNumbers(value);
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(DeleteStartNNumbersTestSource))]
        public void DeleteStartNNumbersTest(int value, ArrayList list, ArrayList expectedList)
        {
            list.DeleteStartNNumbers(value);
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(DeleteNElementsTestSource))]
        public void DeleteNElementsTest(int n, int index, ArrayList list, ArrayList expectedList)
        {
            list.DeleteStartNNumbers(n, index);
            Assert.AreEqual(expectedList, list);
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
    }
}