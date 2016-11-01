using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuicksortAlgoritm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuicksortAlgoritm.Tests
{
    [TestClass()]
    public class QuicksortTestTests
    {
        [TestMethod()]
        public void QuicksortTest_True__20_ints()
        {
            int[] arrayToSort = new int[] {5,7,8,6,3,1,9,2,10,4,11,18,13,19,20,17,15,12,14,16};
            int[] expectedArray = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

            QuicksortAlgoritm.QuicksortTest.Quicksort(arrayToSort, 0, arrayToSort.Length - 1);

            CollectionAssert.AreEqual(expectedArray, arrayToSort);
        }
        [TestMethod()]
        public void QuicksortTest_False__expect_21_ints()
        {
            int[] arrayToSort = new int[] { 5, 7, 8, 6, 3, 1, 9, 2, 10, 4, 11, 18, 13, 19, 20, 17, 15, 12, 14, 16 };
            int[] expectedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21};

            QuicksortAlgoritm.QuicksortTest.Quicksort(arrayToSort, 0, arrayToSort.Length - 1);

            CollectionAssert.AreNotEqual(expectedArray, arrayToSort);
        }
        [TestMethod()]
        public void QuicksortTest_False__20_ints_wrong_segquence()
        {
            int[] arrayToSort = new int[] { 5, 7, 8, 6, 3, 1, 9, 2, 10, 4, 11, 18, 13, 19, 20, 17, 15, 12, 14, 16 };
            int[] expectedArray = new int[] { 20, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 1 };

            QuicksortAlgoritm.QuicksortTest.Quicksort(arrayToSort, 0, arrayToSort.Length - 1);

            CollectionAssert.AreNotEqual(expectedArray, arrayToSort);
        }
        [TestMethod()]
        public void QuicksortTest_False__To_many()
        {
            int[] arrayToSort = new int[] { 4,3,2,1,4,3,2,1,4,3,2,1,4,3,2,1,4,3,2,1 };
            int[] expectedArray = new int[] { 1,2,3,4 };

            QuicksortAlgoritm.QuicksortTest.Quicksort(arrayToSort, 0, arrayToSort.Length - 1);

            CollectionAssert.AreNotEqual(expectedArray, arrayToSort);
        }
        [TestMethod()]
        public void QuicksortTest_True__5_of_same()
        {
            int[] arrayToSort = new int[] { 4, 3, 2, 1, 4, 3, 2, 1, 4, 3, 2, 1, 4, 3, 2, 1, 4, 3, 2, 1 };
            int[] expectedArray = new int[] { 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4 };

            QuicksortAlgoritm.QuicksortTest.Quicksort(arrayToSort, 0, arrayToSort.Length - 1);

            CollectionAssert.AreEqual(expectedArray, arrayToSort);
        }
    }
}