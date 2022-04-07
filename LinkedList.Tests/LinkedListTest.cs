
using NUnit.Framework;
using ProjectList.Tests.LinkedListTestsSources;
using ProjectList.Tests.LinkedListNegativeTestsSources;
using System;
using ProjectList;
namespace ProjectList.Tests
{
    public class LinkedListTest
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(ProjectList.LinkedList actuallist, LinkedList expected, int value)
        {
            actuallist.AddLast(value);
            Assert.AreEqual(expected, actuallist);
        }
        [TestCaseSource(typeof(AddStartTestSource))]
        public void AddStartTest(ProjectList.LinkedList actuallist, LinkedList expected, int value)
        {
            actuallist.AddStart(value);
            Assert.AreEqual(expected, actuallist);
        }
        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(ProjectList.LinkedList actuallist, LinkedList expected, int value, int index)
        {
            actuallist.AddByIndex(value, index);
            Assert.AreEqual(expected, actuallist);
        }
        [TestCaseSource(typeof(AddByIndexNegativeTestSource))]
        public void AddByIndexTest_WhenIndexOutOfLength_ShouldThrowException(LinkedList actuallist, int value, int index)
        {
            Assert.Throws<ArgumentException>(() => actuallist.AddByIndex(index, value));
        }
        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(ProjectList.LinkedList actuallist, LinkedList expected)
        {
            actuallist.DeleteLast();
            Assert.AreEqual(expected, actuallist);
        }
        [TestCaseSource(typeof(DeleteLastNegativeTestSource))]
        public void DeleteLastTest_WhenLengthLessThanZero(LinkedList actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteLast());
        }
        [TestCaseSource(typeof(DeleteStartTestSource))]
        public void DeleteStartTest(ProjectList.LinkedList actuallist, LinkedList expected)
        {
            actuallist.DeleteStart();
            Assert.AreEqual(expected, actuallist);
        }
        [TestCaseSource(typeof(DeleteStartNegativeTestSource))]
        public void DeleteStartTest_WhenLengthLessThanZero(LinkedList actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteStart());
        }
        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(ProjectList.LinkedList actuallist, LinkedList expected, int index)
        {
            actuallist.DeleteByIndex(index);
            Assert.AreEqual(expected, actuallist);
        }
        [TestCaseSource(typeof(DeleteByIndextNegativeTestSource))]
        public void DeleteByIndextTest_WhenIndexLessThanZero_OrMoreThanOrEqualLength(LinkedList actuallist, int index)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteByIndex(index));
        }
        [TestCaseSource(typeof(DeleteLastNElementsTestSource))]
        public void DeleteLastNElementsTest(ProjectList.LinkedList actuallist, LinkedList expected, int value)
        {
            actuallist.DeleteLastNElements(value);
            Assert.AreEqual(expected, actuallist);
        }
        [TestCaseSource(typeof(DeleteLastNElementsNegativeTestSource))]
        public void DeleteLastNElementsTest_WhenValueMoreThanLength(LinkedList actuallist, int value)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteStartNElements(value));
        }
        [TestCaseSource(typeof(DeleteStartNElementsTestSource))]
        public void DeleteStartNElementsTest(ProjectList.LinkedList actuallist, LinkedList expected, int value)
        {
            actuallist.DeleteStartNElements(value);
            Assert.AreEqual(expected, actuallist);
        }
        [TestCaseSource(typeof(DeleteStartNElementsNegativeTestSource))]
        public void DeleteStartNElementsTest_WhenValueMoreThanLength(LinkedList actuallist, int value)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteStartNElements(value));
        }
        [TestCaseSource(typeof(DeleteNElementsByIndexTestSource))]
        public void DeleteNElementsByIndexTest(ProjectList.LinkedList actuallist, LinkedList expected, int index, int value)
        {
            actuallist.DeleteNElementsByIndex(index, value);
            Assert.AreEqual(expected, actuallist);
        }
        [TestCaseSource(typeof(DeleteNElementsByIndexNegativeTestSource))]
        public void DeleteNElementsByIndexTest_WhenValueMoreThanLength_WhenIndexLessThanZero(LinkedList actuallist, int index, int value)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteNElementsByIndex(index,value));
        }
        [TestCaseSource(typeof(FindIndexByFirstElementTestSource))]
        public void FindIndexByFirstElementTest(LinkedList list, int expected, int value)
        {
            int actual = list.FindIndexByFirstElement(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(FindIndexByFirstElementNegativeTestSource))]
        public void FindIndexByFirstElement_WhenLengthRavnoZero(LinkedList list, int expected, int value)
        {
            Assert.Throws<Exception>(() => list.FindIndexByFirstElement(value));
        }
        [TestCaseSource(typeof(ChangeElementByIndexTestSource))]
        public void ChangeElementByIndexTest(ProjectList.LinkedList actuallist, LinkedList expected, int index, int value)
        {
            actuallist.ChangeElementByIndex(index, value);
            Assert.AreEqual(expected, actuallist);
        }
        [TestCaseSource(typeof(ChangeElementByIndexNegativeTestSource))]
        public void ChangeElementByIndexTest_WhenIndexMoreThanLength_WhenIndexLessThanZero(LinkedList actuallist, int index, int value)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.ChangeElementByIndex(index, value));
        }
        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(ProjectList.LinkedList actuallist, LinkedList expected)
        {
            actuallist.Reverse();
            Assert.AreEqual(expected, actuallist);
        }
    }
        
}
