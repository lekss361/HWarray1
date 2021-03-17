using NUnit.Framework;

namespace HW.Tests
{
    public class BranchingTest
    {
        [TestCase(5, 4, 9)]
        [TestCase(4, 4, 16)]
        [TestCase(4, 5, -1)]

        public void Task1Test(int x, int y, int expected)
        {
            int actual = Branching.Task1(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 1)]
        [TestCase(1, -1, 2)]
        [TestCase(-1, 1, 4)]

        public void WhichQuarterBelongs2Test(int x, int y, int expected)
        {
            int actual = Branching.WhichQuarterBelongs2(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 3, 2, new int[]{1, 2, 3})]
        [TestCase(-1,-5,6, new int[] {-5, -1, 6})]
        [TestCase(-5,0,2, new int[] {-5, 0, 2})]

        public void SortAscendingOrder3Test(int x, int y, int z, int[] expected)
        {
            int[] actual = Branching.SortAscendingOrder3(x, y, z);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,-4,4, new double[] {2,2})]
        [TestCase(1,3,-4, new double[] {1,-4})]
        [TestCase(1,-11,18, new double[] {9, 2})]

        public void SolutionQuadraticEquation4(int x, int y, int z, double[] expected)
        {
            double[] actual = Branching.SolutionQuadraticEquation4(x, y, z);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(11, "одиннадцать")]
        [TestCase(21, "двадцать один")]
        [TestCase(55, "пятьдесят пять")]

        public void NumbersInWords5Test(int x,string expected)
        {
            string actual = Branching.NumbersInWords5(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
