using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        //{
        //    // arrange
        //    CustomList<int> testList = new CustomList<int>();
        //    int itemToAdd = 10;
        //    int expected = 10;
        //    int actual;

        //    // act
        //    testList.Add(itemToAdd);
        //    actual = testList[0];

        //    // assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        //{
        //    // arrange
        //    CustomList<int> testList = new CustomList<int>();
        //    int itemToAdd = 10;
        //    int expected = 1;
        //    int actual;

        //    // act
        //    testList.Add(itemToAdd);
        //    actual = testList.Count;

        //    // assert
        //    Assert.AreEqual(expected, actual);
        //}
        
        // what happens if you add multiple things (or add to a CustomList that already has some values)?
            // what happens to the last-added item?
            // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

        [TestMethod]

        public void AddOneValueAndSearchListForIndexTwo()
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
        
        [TestMethod]
        public void Add_AddingOneToIndexZero()
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

        [TestMethod]
        public void Add_AddingTwoValues()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int itemToAddTwo = 20;
            int expected = 2;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingValue()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int itemToAdd = 20;
            int expected = 20;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Remove(10);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingTwoValues()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int itemToAddTwo = 20;
            int itemToAddThree = 45;
            int expected = 20;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Remove(itemToAdd);
            testList.Remove(itemToAddThree);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingFourValues()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 5;
            int itemToAddTwo = 45;
            int itemToAddThree = 90;
            int itemToAddFour = 170;
            int itemToAddFive = 4;
            int expected = 4;
            int actual;
            //act
            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Add(itemToAddFour);
            testList.Add(itemToAddFive);
            testList.Remove(itemToAddThree);
            actual = testList[3];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingValue_CountValuesLeftover()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int itemToAddTwo = 20;
            int itemToAddThree = 56;
            int itemToAddFour = 78;

            int expected = 3;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Add(itemToAddFour);
            testList.Remove(itemToAddTwo);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveOneValue_CheckCapacity()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 43;
            int itemToAddTwo = 80;
            int itemToAddThree = 38;
            int expected = 4;
            int actual;
            //act
            testList.Add(itemToAdd);
            testList.Add(itemToAddTwo);
            testList.Add(itemToAddThree);
            testList.Remove(itemToAddTwo);
            actual = testList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
