﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    class HW2Array
    {
        public static int MinOfArray1(int[,] Array)
        {
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

        public static int MaxOfArray2(int[,] Array)
        {
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

        public static (int,int) IndexMinOfArray3(int[,] Array)
        {
            int IndexMinNumberX = 0;
            int IndexMinNumberY = 0;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[IndexMinNumberX,IndexMinNumberY] > Array[i, j])
                    {
                        IndexMinNumberX = i;
                        IndexMinNumberY = j;
                    }

                }
            }
            
            return (IndexMinNumberX,IndexMinNumberY);
        }

        public static (int,int) IndexMaxOfArray4(int[,] Array)
        {
            int IndexMaxNumberX = 0;
            int IndexMaxNumberY = 0;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[IndexMaxNumberX, IndexMaxNumberY] < Array[i, j])
                    {
                        IndexMaxNumberX = i;
                        IndexMaxNumberY = j;
                    }

                }
            }
            return (IndexMaxNumberX,IndexMaxNumberY);
        }
        public static int NumberMoreNeighbors5(int[,] Array)
        {
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
            bool Count=false;
            if (height==0&&Lenght==0)
            {
                Count = Array[height, Lenght] > Array[height + 1, Lenght] && Array[height, Lenght] > Array[height, Lenght + 1] ? true : false;
            }
            else if (height==0&&Lenght==Array.GetLength(1)-1)
            {
                Count = Array[height, Lenght] > Array[height + 1, Lenght] && Array[height, Lenght] > Array[height, Lenght - 1] ? true : false;
            }
            else if (height==Array.GetLength(0)-1&&Lenght==0)
            {
                Count = Array[height, Lenght] > Array[height - 1, Lenght] && Array[height, Lenght] > Array[height, Lenght + 1] ? true : false;
            }
            else if (height == Array.GetLength(0)-1 && Lenght == Array.GetLength(1) - 1)
            {
                Count = Array[height, Lenght] > Array[height - 1, Lenght] && Array[height, Lenght] > Array[height, Lenght - 1] ? true : false;
            }
            else if (height == 0)
            {
                Count = Array[height, Lenght] > Array[height, Lenght-1] && Array[height, Lenght] > Array[height, Lenght + 1]&& Array[height, Lenght] > Array[height + 1, Lenght] ? true : false;
            }
            else if (Lenght == 0)
            {
                Count = Array[height, Lenght] > Array[height-1, Lenght] && Array[height, Lenght] > Array[height+1, Lenght ]&& Array[height, Lenght] > Array[height, Lenght+1] ? true : false;
            }
            else if (Lenght == Array.GetLength(1)-1)
            {
                Count = Array[height, Lenght] > Array[height - 1, Lenght] && Array[height, Lenght] > Array[height + 1, Lenght] && Array[height, Lenght] > Array[height, Lenght - 1] ? true : false;
            }
            else if (height == Array.GetLength(0)-1)
            {
                Count = Array[height, Lenght] > Array[height, Lenght-1] && Array[height, Lenght] > Array[height, Lenght + 1]&& Array[height, Lenght] > Array[height - 1, Lenght] ? true : false;
            }
            else
            {
                Count = Array[height, Lenght] > Array[height, Lenght - 1] && Array[height, Lenght] > Array[height, Lenght + 1] 
                        && Array[height, Lenght] > Array[height - 1, Lenght]&& Array[height, Lenght] > Array[height + 1, Lenght] ? true : false;
            }
            return Count;
        }

        public static int[,] BackwardMainDiagonalArray(int[,] Array)
        {
            
            for (int i = 1; i < Array.GetLength(0); ++i)
                for (int j = 0; j < i; ++j)
                {
                    int tmp = Array[j, i];
                    Array[j, i] = Array[i, j];
                    Array[i, j] = tmp;
                }
            return Array;
        }
    }
}