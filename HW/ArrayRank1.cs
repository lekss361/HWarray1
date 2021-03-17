using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    public static class ArrayRank1
    {
        public static void PrintInfoTask()
        {
            string[] InfoTask = new string[10]
            {
              "1. Найти минимальный элемент массива",
              "2. Найти максимальный элемент массива",
              "3. Найти индекс минимального элемента массива",
              "4. Найти индекс максимального элемента массива",
              "5. Посчитать сумму элементов массива с нечетными индексами",
              "6. Сделать реверс массива (массив в обратном направлении)",
              "7. Посчитать количество нечетных элементов массива",
              "8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.",
              "9. Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором (Select) или вставками (Insert))",
              "10. Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором (Select) или вставками (Insert))"
            };

            for (int i = 0; i < InfoTask.Length; i++)
            {
                Console.WriteLine(InfoTask[i]);
            }
        }

        public static int MinOfArray_1(int[] Array)
        {
            if (Array.Length==0)
            {
                throw new ArgumentException("array lenght==0");
            }

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
        
        public static int MaxOfArray_2(int[] Array)
        {
            if (Array.Length == 0)
            {
                throw new ArgumentException("array lenght==0");
            }

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

        public static int IndexMinOfArray_3(int[] Array)
        {
            if (Array.Length == 0)
            {
                throw new ArgumentException("array lenght==0");
            }

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

        public static int IndexMaxOfArray_4(int[] Array)
        {
            if (Array.Length == 0)
            {
                throw new ArgumentException("array lenght==0");
            }

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
        public static int SummOddIndexOfArray_5(int[] Array)
        {
            if (Array.Length == 0)
            {
                throw new ArgumentException("array lenght==0");
            }

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

        public static int [] BackwardArray_6(int[] Array)
        {
            if (Array.Length == 0)
            {
                throw new ArgumentException("array lenght==0");
            }

            int[] BackwardArray = new int[Array.Length];

            for (int i = 0; i < Array.Length; i++)
            {
                BackwardArray[i] = Array[Array.Length - i-1];
            }
            return BackwardArray;
        }

        public static int QountOddNumberOfArray_7(int[] Array)
        {
            if (Array.Length == 0)
            {
                throw new ArgumentException("array lenght==0");
            }

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

        public static int[] BackwardHalfArray_8(int[] Array)
        {
            int j = Array.Length-1;
            if (Array.Length == 0)
            {
                throw new ArgumentException("array lenght==0");
            }

            int tmp;
            int i2;
            i2 = Array.Length - 1;

            for (int i = Array.Length / 2 - 1; i >= 0; i--)
            {
                tmp = Array[i];
                Array[i] = Array[i2];
                Array[i2] = tmp;
                i2--;
            }

            return Array;
        }

        public static int[] BubleSortArray_9(int[] Array)
        {
            if (Array.Length == 0)
            {
                throw new ArgumentException("array lenght==0");
            }

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
        public static int[] SelectSortArray_10(int[] Array)
        {
            if (Array.Length == 0)
            {
                throw new ArgumentException("array lenght==0");
            }

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
