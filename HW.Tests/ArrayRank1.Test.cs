using NUnit.Framework;
using System;

namespace HW.Tests
{
    public class ArrayRank1Test
    {
        [TestCase(new int[] { 1, 2, 4, 5, 6, 7, 8, 9, }, 1)]
        [TestCase(new int[] { -1, 2, 4, 5, 6, 7, 8, 9, 0 }, -1)]
        [TestCase(new int[] { 0, 0, 0, 0 }, 0)]

        public void MinOfArray_1Test(int[] x, int expected)
        {
            int actual = ArrayRank1.MinOfArray_1(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]

        public void MinOfArray_1_ArrayLenght0_ShouldException(int[] x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank1.MinOfArray_1(x));
        }

        [TestCase(new int[] { 1, 2, 4, 5, 6, 7, 8, 9 }, 9)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -1)]
        [TestCase(new int[] { 0, 0, 0, 0 }, 0)]

        public void MaxOfArray_2Test(int[] x, int expected)
        {
            int actual = ArrayRank1.MaxOfArray_2(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[]{})]
        public void MaxOfArray_2_ArrayLenghtTo0_ShouldEception(int[] x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank1.MaxOfArray_2(x));
        }

        [TestCase(new int[] { 1, 2, 4, 5, 6, 7, 8, 9 }, 0)]
        [TestCase(new int[] { 1, -2, -3, -4, -5 }, 4)]
        [TestCase(new int[] { 0, 0, 0, 0 }, 0)]

        public void IndexMinOfArray_3Test(int[] x, int expected)
        {
            int actual = ArrayRank1.IndexMinOfArray_3(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[]{})]
        public void IndexMinOfArray_3_ArrayLenghtTo0_ShouldEception(int[] x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank1.IndexMinOfArray_3(x));
        }

        [TestCase(new int[] { 1, 2, 4, 5, 6, 7, 8, 9 }, 7)]
        [TestCase(new int[] { 1, -2, -3, -4, -5 }, 0)]
        [TestCase(new int[] { 0, 0, 0, 0 }, 0)]

        public void IndexMaxOfArray_4Test(int[] x, int expected)
        {
            int actual = ArrayRank1.IndexMaxOfArray_4(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[]{})]
        public void IndexMaxOfArray_4_ArrayLenghtTo0_ShouldEception(int[] x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank1.IndexMaxOfArray_4(x));
        }

        [TestCase(new int[] {1,2,3,4,5 },6)]
        [TestCase(new int[] { 1, -2, 3, 4, 5 }, 2)]
        [TestCase(new int[] { 1, 0, 3, 0, 5 }, 0)]

        public void SummOddIndexOfArray_5Test(int[] x, int exprcted)
        {
            int actual = ArrayRank1.SummOddIndexOfArray_5(x);

            Assert.AreEqual(exprcted, actual);
        }

        [TestCase(new int[] { })]
        public void SummOddIndexOfArray_5_ArrayLenghtTo0_ShouldEception(int[] x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank1.SummOddIndexOfArray_5(x));
        }

        [TestCase(new int[] {1,2,3,4,5 }, new int[] { 5,4,3,2,1 })]
        [TestCase(new int[] { 1, -2, 3, -4, 5 }, new int[] { 5, -4, 3, -2, 1 })]
        [TestCase(new int[] { 0,0,0,0,1 }, new int[] { 1,0,0,0,0 })]

        public void BackwardArray_6Test(int[] x, int[] expected)
        {
            int[] actual = ArrayRank1.BackwardArray_6(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void BackwardArray_6_ArrayLenghtTo0_ShouldEception(int[] x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank1.BackwardArray_6(x));
        }

        [TestCase(new int[] {1,2,3,4,5 }, 3)]
        [TestCase(new int[] { 1, -2, 3, -4, 5 }, 3)]
        [TestCase(new int[] { 0,0,0,0,1 }, 1)]

        public void QountOddNumberOfArray_7Test(int[] x, int expected)
        {
            int actual = ArrayRank1.QountOddNumberOfArray_7(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]

        public void QountOddNumberOfArray_7_ArrayLenghtTo0_ShouldException(int[] x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank1.QountOddNumberOfArray_7(x));
        }

        [TestCase(new int[] {1,2 }, new int[] {2,1 })]
        [TestCase(new int[] { 1, -2, 3, -4, 5 },new int[] {-4,5,3,1,-2 })]
        [TestCase(new int[] { 4,2,3,1 }, new int[] {3,1,4,2 })]

        public void BackwardHalfArray_8Test(int[] x, int[] expected)
        {
            int[] actual = ArrayRank1.BackwardHalfArray_8(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]

        public void BackwardHalfArray_8_ArrayLenghtTo0_ShouldException(int[] x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank1.BackwardHalfArray_8(x));
        }

        [TestCase(new int[] {2,1 }, new int[] {1,2 })]
        [TestCase(new int[] { 1, -2, 3, -4, 5 },new int[] {-4,-2,1,3,5 })]
        [TestCase(new int[] { 0,2,0,1 }, new int[] {0,0,1,2 })]

        public void BubleSortArray_9Test(int[] x, int[] expected)
        {
            int[] actual = ArrayRank1.BubleSortArray_9(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]

        public void BubleSortArray_9_ArrayLenghtTo0_ShouldException(int[] x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank1.BubleSortArray_9(x));
        }

        [TestCase(new int[] {1,2 }, new int[] {2,1 })]
        [TestCase(new int[] { 1, -2, 3, -4, 5 },new int[] {5,3,1,-2,-4 })]
        [TestCase(new int[] { 0,2,0,1 }, new int[] {2,1,0,0})]

        public void SelectSortArray_10Test(int[] x, int[] expected)
        {
            int[] actual = ArrayRank1.SelectSortArray_10(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]

        public void SelectSortArray_10_ArrayLenghtTo0_ShouldException(int[] x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank1.SelectSortArray_10(x));
        }

    }
}
