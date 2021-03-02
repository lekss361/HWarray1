using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    public static class HW1Array
    {
        public static int MinOfArray1(int[] Array)
        {
            int MinNumber=Array[0];

            for (int i = 0; i < Array.Length; i++)
            {
                if (MinNumber>Array[i])
                {
                    MinNumber = Array[i];
                }
            }
            return MinNumber;
        }
        
        public static int MaxOfArray2(int[] Array)
        {
            int MaxNumber=Array[0];

            for (int i = 0; i < Array.Length; i++)
            {
                if (MaxNumber<Array[i])
                {
                    MaxNumber = Array[i];
                }
            }
            return MaxNumber;
        }

        public static int IndexMinOfArray3(int[] Array)
        {
            int IndexMinNumber=Array[0];

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[IndexMinNumber]>Array[i])
                {
                    IndexMinNumber = i;
                }
            }
            return IndexMinNumber;
        }

        public static int IndexMaxOfArray4(int[] Array)
        {
            int IndexMaxNumber=Array[0];

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[IndexMaxNumber] < Array[i])
                {
                    IndexMaxNumber = i;
                }
            }
            return IndexMaxNumber;
        }
        public static int SummOddIndexOfArray5(int[] Array)
        {
            int Summ=0;

            for (int i = 0; i < Array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Summ += Array[i];
                }
            }
            return Summ;
        }

        public static int [] BackwardArray6(int[] Array)
        {
            int[] BackwardArray = new int[Array.Length];

            for (int i = 0; i < Array.Length; i++)
            {
                BackwardArray[i] = Array[Array.Length -1 - i];
            }
            return BackwardArray;
        }

        public static int QountOddNumberOfArray7(int[] Array)
        {
            int QountOddNumber=0;

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i]%2!=0)
                {
                    QountOddNumber++;
                }
            }
            return QountOddNumber;
        }

        public static int[] BackwardHalfArray8(int[] Array)
        {
            int[] BackwardHalfArray = new int[Array.Length];
            int MidIndex=Array.Length%2==0?Array.Length/2:Array.Length/2+1;

            for (int i = 0; i < MidIndex; i++)
            {
                BackwardHalfArray[i] = Array[MidIndex + i];
                BackwardHalfArray[MidIndex + i] = Array[i];
            }
            return BackwardHalfArray;
        }

        public static int[] BubleSortArray9(int[] Array)
        {
            int tmp;
            for (int i = 1; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length-i; j++)
                {
                    if (Array[j]>Array[j+1])
                    {
                        tmp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = tmp;
                    }
                }
            }
            return Array;
        }
        public static int[] SelectSortArray10(int[] Array)
        {
            int tmp=0;
            int tmp2 = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                tmp=i;
                for (int j = i; j < Array.Length; j++)
                {
                    
                    if (Array[tmp]<Array[j])
                    {
                        tmp = j;
                    }
                }

                tmp2 = Array[i];
                Array[i] = Array[tmp];
                Array[tmp] = tmp2;
            }
            return Array;
        }

    }
}
