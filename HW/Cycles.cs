using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
   public static class Cycles
    {
        public static void PrintInfoTask()
        {
            string[] InfoTask = new string[12]
            {
              "1. Пользователь вводит 2 числа (A и B). Возвести число A в степень B.",
              "2. Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.",
              "3. Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.",
              "4. Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.",
              "5. Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).",
              "6. Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными",
              "7. Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.",
              "8. Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.",
              "9. Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.",
              "10. Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.",
              "11. Пользователь вводит целое положительное  число (N). Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечет",
              "12. Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”."
            };

            for (int i = 0; i < InfoTask.Length; i++)
            {
                Console.WriteLine(InfoTask[i]);
            }
        }

        public static int Pow_1(int X, int Y)
        {
            int Result = 1;

            if (X == 0 || Y <= 0)
            {
                throw new Exception("недопустимые значения ");
            }

            for (int i = 0; i < Y; i++)
            {
                Result = Result * X;
            }

            return Result;
        }

        public static int[] DivisionNonResidue_2(int X)
        {
            int[] NoneResidue = new int[1000 / X];
            int tmp = 0;

            if (X <= 0)
            {
                throw new Exception("недопустимые значения ");
            }

            for (int i = 1; i <= 1000; i++)
            {
                if (i % X == 0)
                {
                    NoneResidue[tmp] = i;
                    tmp++;
                }
            }

            return NoneResidue;
        }

        public static int QountQuadNumberLessVariable_3(int X)
        {
            int tmp = 1;

            if (X <= 0)
            {
                throw new Exception("недопустимые значения ");
            }

            while (tmp * tmp < X)
            {
                tmp++;
            }

            tmp--;

            return tmp;
        }

        public static int GreatestDivisor_4(int X)
        {
            int Result = 0;

            if (X <= 0)
            {
                throw new Exception("недопустимые значения ");
            }

            for (int i = 1; i < X - 1; i++)
            {
                if (X % i == 0)
                {
                    Result = i;
                }
            }

            return Result;
        }

        public static int SummNumbersDivisionNonResidueOn7_5(int X, int Y)
        {
            int tmp = 0, Result = 0;

            if (X > Y)
            {
                tmp = X;
                X = Y;
                Y = tmp;
            }

            for (int i = X; i < Y; i++)
            {
                if (i % 7 == 0)
                {
                    Result += i;
                }
            }

            return Result;
        }

        public static int NumberFibonacci_6(int X)
        {
            int tmp = 1, tmp1 = 1, Result = 0;

            if (X < 0)
            {
                throw new Exception("недопустимые значения ");
            }

            for (int i = 0; i < X; i++)
            {
                Result = tmp + tmp1;
                tmp = tmp1;
                tmp1 = Result;
            }

            return Result;
        }

        public static int MaxDividerMetodEuclid_7(int X, int Y)
        {
            int Result = 0;

            if (X == 0 || Y == 0)
            {
                throw new Exception("недопустимые значения ");
            }

            while (X != 0 && Y != 0)
            {
                if (X > Y)
                {
                    X = X % Y;
                }
                else if (X != 0 && Y != 0)
                {
                    Y = Y % X;
                }
            }

            Result = X + Y;

            return Result;
        }

        public static double[] BinarySearch_8(int X, double Inaccuracy)
        {
            double[] Result = new double[2];
            double DigitCount = (int)Math.Log10(X) + 1;
            double MinNumber = 0;
            double MaxNumber = (int)Math.Pow(10, DigitCount);
            double MidNumber = 0;
            double Answer = Inaccuracy + 1;

            if (X < 0)
            {
                throw new Exception("недопустимые значения ");
            }

            while (Answer > Inaccuracy)
            {
                MidNumber = (MinNumber + MaxNumber) / 2;

                int MidNUmberCoube = (int)Math.Pow(MidNumber, 3.0);

                if (MidNUmberCoube > X && MidNumber > X)
                {
                    MaxNumber = MidNumber;
                }
                else
                {
                    MinNumber = MidNumber;
                }

                if (MaxNumber - MinNumber <= Inaccuracy)
                {
                    Answer = MaxNumber - MinNumber;

                    Result[0] = MidNumber;
                    Result[1] = Answer;
                }
            }

            Result[0] = Math.Round(Result[0], 1);
            Result[1] = Math.Round(Result[1], 1);
            return Result;
        }

        public static int CountOddNumbersOfNumeral_9(int X)
        {
            int tmp = 0;
            int Result = 0;

            while (X > 0)
            {
                tmp = X % 10;

                if (tmp % 2 != 0)
                {
                    Result++;
                }

                X /= 10;
            }

            return Result;
        }

        public static int BackwardsNumber_10(int X)
        {
            int Result = 0;
            int DigitCount = (int)Math.Log10(X) + 1;

            if (X < 0)
            {
                throw new Exception("недопустимые значения ");
            }

            for (int i = 0; i < DigitCount; i++)
            {
                Result += (X % 10) * (int)Math.Pow(10, DigitCount - i - 1);
                X /= 10;

            }

            return Result;
        }


        public static int[] SummEvenMoreSummOdd_11(int X)
        {
            int Even = 0, Odd = 0, tmp = 0, tmp1 = 0,tmp2=0;
            int[] Result = new int[1];

            for (int i = 1; i <= X; i++)
            {
                tmp1 = i;

                while (tmp1 > 0)
                {
                    tmp = tmp1 % 10;
                    tmp1 /= 10;

                    if (tmp % 2 == 0)
                    {
                        Even += tmp;
                    }
                    else
                    {
                        Odd += tmp;
                    }
                }

                if (Even > Odd)
                {
                    Result[tmp2] = i;
                    tmp2++;

                    Array.Resize(ref Result, Result.Length + 1);
                }

                Even = 0;
                Odd = 0;
            }

            return Result;
        }

        public static bool CoincidenceNumbers_12(int X, int Y)
        {
            int DigitCount = (int)Math.Log10(X) + 1;
            int DigitCount1 = (int)Math.Log10(Y) + 1;
            int tmp = 0, tmp1 = 0;

            for (int i = 0; i < DigitCount1; i++)
            {
                tmp = X % 10;
                X /= 10;

                for (int y = 0; y < DigitCount1; y++)
                {
                    tmp1 = Y % 10;
                    Y /= 10;

                    if (tmp == tmp1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
