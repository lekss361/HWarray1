using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    public class ArrayRank2
    {
        public static int MinOfArray_1(int[,] Array)
        {
            if (Array.GetLength(0) < 1 || Array.GetLength(1) < 1)
            {
                throw new ArgumentException("Массив пуст");
            }

            int MinNumber = 0;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                if (MinNumber > Array[i,j])
                {
                    MinNumber = Array[i,j];
                }

                }
            }
            return MinNumber;
        }

        public static int MaxOfArray_2(int[,] Array)
        {
            if (Array.GetLength(0) < 1 || Array.GetLength(1) < 1)
            {
                throw new ArgumentException("Массив пуст");
            }

            int MaxNumber = 0;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (MaxNumber < Array[i, j])
                    {
                        MaxNumber = Array[i, j];
                    }

                }
            }
            return MaxNumber;
        }

        public static int[] IndexMinOfArray_3(int[,] Array)
        {
            if (Array.GetLength(0) < 1 || Array.GetLength(1) < 1)
            {
                throw new ArgumentException("Массив пуст");
            }

            int[] result = new int[2];
            result[0] = 0;
            result[1] = 0;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[result[0],result[1]] > Array[i, j])
                    {
                        result[0] = i;
                        result[1] = j;
                    }

                }
            }
            
            return result;
        }

        public static int[] IndexMaxOfArray_4(int[,] Array)
        {
            if (Array.GetLength(0) < 1 || Array.GetLength(1) < 1)
            {
                throw new ArgumentException("Массив пуст");
            }

            int[] result = new int[2];
            result[0] = 0;
            result[1] = 0;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[result[0], result[1]] < Array[i, j])
                    {
                        result[0] = i;
                        result[1] = j;
                    }

                }
            }
            return result;
        }
        public static int NumberMoreNeighbors_5(int[,] Array)
        {
            if (Array.GetLength(0) < 1 || Array.GetLength(1) < 1)
            {
                throw new ArgumentException("Массив пуст");
            }

            int Count = 0;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (MoreNeighbors(i,j,Array))
                    {
                        Count++;
                    }

                }
            }
            return Count;
        }

        private static bool MoreNeighbors(int height, int Lenght, int[,] Array)
        {
            if (Array.GetLength(0) < 1 || Array.GetLength(1) < 1)
            {
                throw new ArgumentException("Массив пуст");
            }

            bool Count=false;           

            if (height == 0 && Lenght == 0)
            {
                Count = Array[height, Lenght] > Array[height + 1, Lenght] && Array[height, Lenght] > Array[height, Lenght + 1] ? true : false;
            }
            else if (height == 0 && Lenght == Array.GetLength(1) - 1)
            {
                Count = Array[height, Lenght] > Array[height + 1, Lenght] && Array[height, Lenght] > Array[height, Lenght - 1] ? true : false;
            }
            else if (height == Array.GetLength(0) - 1 && Lenght == 0)
            {
                Count = Array[height, Lenght] > Array[height - 1, Lenght] && Array[height, Lenght] > Array[height, Lenght + 1] ? true : false;
            }
            else if (height == Array.GetLength(0) - 1 && Lenght == Array.GetLength(1) - 1)
            {
                Count = Array[height, Lenght] > Array[height - 1, Lenght] && Array[height, Lenght] > Array[height, Lenght - 1] ? true : false;
            }
            else if (height == 0)
            {
                Count = Array[height, Lenght] > Array[height, Lenght - 1] && Array[height, Lenght] > Array[height, Lenght + 1] && Array[height, Lenght] > Array[height + 1, Lenght] ? true : false;
            }
            else if (Lenght == 0)
            {
                Count = Array[height, Lenght] > Array[height - 1, Lenght] && Array[height, Lenght] > Array[height + 1, Lenght] && Array[height, Lenght] > Array[height, Lenght + 1] ? true : false;
            }
            else if (Lenght == Array.GetLength(1) - 1)
            {
                Count = Array[height, Lenght] > Array[height - 1, Lenght] && Array[height, Lenght] > Array[height + 1, Lenght] && Array[height, Lenght] > Array[height, Lenght - 1] ? true : false;
            }
            else if (height == Array.GetLength(0) - 1)
            {
                Count = Array[height, Lenght] > Array[height, Lenght - 1] && Array[height, Lenght] > Array[height, Lenght + 1] && Array[height, Lenght] > Array[height - 1, Lenght] ? true : false;
            }
            else
            {
                Count = Array[height, Lenght] > Array[height, Lenght - 1] && Array[height, Lenght] > Array[height, Lenght + 1]
                        && Array[height, Lenght] > Array[height - 1, Lenght] && Array[height, Lenght] > Array[height + 1, Lenght] ? true : false;
            }
            return Count;
        }

        public static int[,] BackwardMainDiagonalArray_6(int[,] Array)
        {
            if (Array.GetLength(0) < 1 || Array.GetLength(1) < 1)
            {
                throw new ArgumentException("Массив пуст");
            }

            int[,] transposedArray = new int[Array.GetLength(1), Array.GetLength(0)];
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    transposedArray[j, i] = Array[i, j];
                }
            }
            return transposedArray;
        }
    }
}
