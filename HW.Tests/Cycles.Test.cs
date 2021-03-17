using NUnit.Framework;

namespace HW.Tests
{
    public class CyclesTest
    {
        [TestCase(1, 5, 1)]
        [TestCase(2, 2, 4)]
        [TestCase(-2, 3, -8)]

        public void Pow_1(int x, int y, int expected)
        {
            int actual = Cycles.Pow_1(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(750, new int[] { 750 })]

        public void DivisionNonResidue_2Test(int x, int[] expected)
        {
            int[] actual = Cycles.DivisionNonResidue_2(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5,2)]
        [TestCase(9,2)]
        [TestCase(10,3)]

        public void QountQuadNumberLessVariable_3Test(int x, int expected)
        {
            int actual = Cycles.QountQuadNumberLessVariable_3(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3,1)]
        [TestCase(9,3)]
        [TestCase(10,5)]

        public void GreatestDivisor_4Test(int x, int expected)
        {
            int actual = Cycles.GreatestDivisor_4(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,8,7)]
        [TestCase(1,15,21)]
        [TestCase(8,15,14)]

        public void SummNumbersDivisionNonResidueOn7_5Test(int x, int y, int expected)
        {
            int actual = Cycles.SummNumbersDivisionNonResidueOn7_5(x, y);

            Assert.AreEqual(expected,actual);
        }

       [TestCase(3,5)]
       [TestCase(5,13)]
       [TestCase(10,144)]

       public void NumberFibonacci_6Test(int x, int expected)
       {
            int actual = Cycles.NumberFibonacci_6(x);

            Assert.AreEqual(expected, actual);
       }

        [TestCase(3, 1,1)]
        [TestCase(9, 3,3)]
        [TestCase(136, 55,1)]

        public void MaxDividerMetodEuclid_7Test(int x, int y, int expected)
        {
            int actual = Cycles.MaxDividerMetodEuclid_7(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 0.1,new double[] {27.1,0.1})]
        [TestCase(56, 0.1, new double[] { 56, 0.1 })]
        [TestCase(66, 0.01, new double[] { 66, 0.0 })]

        public void BinarySearch_8Test(int x, double y, double[] expected)
        {
            double[] actual = Cycles.BinarySearch_8(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(153,3)]
        [TestCase(222,0)]
        [TestCase(212,1)]

        public void CountOddNumbersOfNumeral_9Test(int x, int expected)
        {
            int actual = Cycles.CountOddNumbersOfNumeral_9(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(123,321)]
        [TestCase(551,155)]
        [TestCase(1,1)]

        public void BackwardsNumber_10Test(int x, int expected)
        {
            int actual = Cycles.BackwardsNumber_10(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(9,new int[] {2,4,6,8, 0})]
        [TestCase(15, new int[] { 2, 4, 6, 8, 12, 14, 0})]
        [TestCase(25, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 0})]

        public void SummEvenMoreSummOdd_11Test(int x, int[] expected)
        {
            int[] actual = Cycles.SummEvenMoreSummOdd_11(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(155,333,false)]
        [TestCase(155,551,true)]
        [TestCase(3358962,62,true)]

        public void CoincidenceNumbers_12Test(int x, int y, bool expected)
        {
            bool actual = Cycles.CoincidenceNumbers_12(x, y);

            Assert.AreEqual(expected, actual);
        }

    }
}
