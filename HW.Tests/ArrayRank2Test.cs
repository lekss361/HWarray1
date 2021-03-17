using NUnit.Framework;
using System;

namespace HW.Tests
{
    public class ArrayRank2Test
    {

        [TestCase(1,0)]
        [TestCase(2,0)]
        [TestCase(3,-11)]

       
        public void MinOfArray_1Test(int moockNumber, int expected)
        {
           int actual=ArrayRank2.MinOfArray_1(GetMock(moockNumber));

           Assert.AreEqual(expected,actual);
        }

        [TestCase(10)]

        public void MinOfArray_1NegativeTest(int x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank2.MinOfArray_1(GetMock(x)));
        }

        [TestCase(1, 9)]
        [TestCase(2, 18)]
        [TestCase(3, 66)]

        public void MaxOfArray_2Test(int moockNumber, int expected)
        {
            int actual = ArrayRank2.MaxOfArray_2(GetMock(moockNumber));

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10)]

        public void MaxOfArray_2NegativeTest(int x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank2.MaxOfArray_2(GetMock(x)));
        }

        [TestCase(1, new int[] {0,0})]
        [TestCase(2, new int[] {0, 1})]
        [TestCase(3, new int[] {2,1})]

        public void IndexMinOfArray_3Test(int moockNumber, int[] expected)
        {
            int [] actual = ArrayRank2.IndexMinOfArray_3(GetMock(moockNumber));

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10)]

        public void IndexMinOfArray_3NegativeTest(int x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank2.IndexMinOfArray_3(GetMock(x)));
        }

        [TestCase(1, new int[] { 2,2 })]
        [TestCase(2, new int[] { 2, 1 })]
        [TestCase(3, new int[] { 2,2 })]

        public void IndexMaxOfArray_4Test(int moockNumber, int[] expected)
        {
            int[] actual = ArrayRank2.IndexMaxOfArray_4(GetMock(moockNumber));

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10)]

        public void IndexMaxOfArray_4NegativeTest(int x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank2.IndexMaxOfArray_4(GetMock(x)));
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 2)]

        public void NumberMoreNeighbors_5Test(int moockNumber, int expected)
        {
            int actual = ArrayRank2.NumberMoreNeighbors_5(GetMock(moockNumber));

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10)]

        public void NumberMoreNeighbors_5NegativeTest(int x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank2.NumberMoreNeighbors_5(GetMock(x)));
        }

        [TestCase(4,7)]
        [TestCase(5,8)]
        [TestCase(6,9)]

        public void BackwardMainDiagonalArray_6Test(int mockNumber, int expectedMockNumber)
        {

            int[,] actual = ArrayRank2.BackwardMainDiagonalArray_6(GetMock(mockNumber));
            int[,] expected = GetMock(expectedMockNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10)]

        public void BackwardMainDiagonalArray_6NegativeTest(int x)
        {
            Assert.Throws<ArgumentException>(() => ArrayRank2.BackwardMainDiagonalArray_6(GetMock(x)));
        }

        public static int[,] GetMock(int number)
        {
            int[,] mock = new int[0, 0];
            switch (number)
            {
                case 1:

                   mock= new int[,]
                   {
                        {1,2,3},
                        {4,5,6},
                        {7,8,9}
                   };
                    break;

                case 2:
                    mock = new int[,]
                    {
                        {11,0,13},
                        {14,15,16},
                        {17,18,0}
                    };
                    break;

                case 3:
                    {
                        mock = new int[,]
                        {
                            {-1,15,22 },
                            {-10,0,55 },
                            {10,-11,66}
                        };
                    }
                    break;

                case 4:
                    mock = new int[,]
                    {
                        {1, 6, -5, 0 },
                        {-2, 7, 3, 10 },
                        {4, -4, 12, 9 },
                        {3, 0, -11, 6 }
                    };
                    break;
                case 5:
                    mock = new int[,]
                    {
                        {-5, -4, -2, 0 },
                        {10, -8, 8, -13 }
                    };
                    break;
                case 6:
                    mock = new int[,]
                    {
                        {0, 3 },
                        {6, 4 },
                        {-5, -4 },
                        {10, -8 }
                    };
                    break;
                case 7:
                    mock = new int[,]
                    {
                        {1, -2, 4, 3 },
                        {6, 7, -4, 0 },
                        {-5, 3, 12, -11 },
                        {0, 10, 9, 6 }
                    };
                    break;
                case 8:
                    mock = new int[,]
                    {
                        {-5, 10 },
                        {-4, -8 },
                        {-2, 8 },
                        {0, -13 }
                    };
                    break;
                case 9:
                    mock = new int[,]
                    {
                        {0, 6, -5, 10 },
                        {3, 4, -4, -8 }
                    };
                    break;

                default:

                    mock = new int[,] { };

                    break;
            }

            return mock;
        }

    }
}