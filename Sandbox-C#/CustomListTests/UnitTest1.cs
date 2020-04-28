using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        
        // what happens if you add multiple things (or add to a CustomList that already has some values)?
            // what happens to the last-added item?
            // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

        [TestMethod]

        public void AddOneValueAndSearchList()
        {
            //arrange 
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 20;
            int itemToAddTwo = 45;
            int itemToAddThree = 65;
            int expected = 65;
            int actual;

            //act 
            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);

            actual = testList[2];

            //assert
            Assert.AreEqual(expected, actual)
        }

        public void AddFind()
        {
            //arrange 
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 1;
            int itemToAddTwo = 445;
            int itemToAddThree = 165;
            int expected = 1;
            int actual;

            //act 
            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);

            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }


    }
}
