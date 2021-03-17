using NUnit.Framework;

namespace HW.Tests
{
    public class VariableTests
    {
         [TestCase(5, 7, 37)]
         [TestCase(0, 1, 1)]
         [TestCase(-5, -6, -11)]
        
         public void ExampleSolution_1_Test(int a, int b, int expected)
         {
            int actual = Variable.ExampleSolution_1(a, b);

            Assert.AreEqual(expected, actual);
         }

        [TestCase(5, 7,new int[] {7,5})]
        [TestCase(0,1, new int[] { 1, 0 })]
        [TestCase(-5,-6, new int[] { -6, -5 })]

        public void SwapVariables_2_Test(int a, int b, int[] expected)
        {
            int[] actual = Variable.SwapVariables_2(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 7, new double[] { 0, 5 })]
        [TestCase(2, 1, new double[] { 2, 0 })]
        [TestCase(-5, -6, new double[] { 0, -5 })]

        public void DivisionResidueVariables_3_Test(int x, int y, double[] expected)
        {
            double[] actual = Variable.DivisionResidueVariables_3(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5,0,8,1)]
        [TestCase(2,0,5,2)]
        [TestCase(5,5,1,0)]
        public void LinearEquationSolution_4_Test(int x, int y, int z, double expected)
        {
            double actual = Variable.LinearEquationSolution_4(x, y, z);

            Assert.AreEqual(expected,actual);
        }

        [TestCase(3,2,-1,-1, "Y=0,75x+-0,25")]
        [TestCase(1,2,4,2, "Y=-0x+2")]
        [TestCase(1.2,5.6,-3.45,8.2, "Y=-0,56x+6,27")]

        public void EquationStraight_5(double x, double y, double z, double q, string expected)
        {
            string actual = Variable.EquationStraight_5(x, y, z, q);

            Assert.AreEqual(expected, actual);
        }
    }
}