using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    public static class Branching
    {
        public static void PrintInfoTask()
        {
            string[] InfoTask = new string[5]
            {
              "1. Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B",
              "2. Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).",
              "3. Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.",
              "4. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.",
              "5. Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”."
            };

            for (int i = 0; i < InfoTask.Length; i++)
            {
                Console.WriteLine(InfoTask[i]);
            }
        }

        public static int Task1(int X, int Y)
        {
            int Result;

            if (X > Y)
            {
                Result = X + Y;
            }
            else if (X == Y)
            {
                Result = X * Y;
            }
            else
            {
                Result = X - Y;
            }

            return Result;
        }

        public static int WhichQuarterBelongs2(int X, int Y)
        {
            int Result;

            if (X > 0 && Y > 0)
            {
                Result = 1;
            }
            else if (X > 0 && Y < 0)
            {
                Result = 2;
            }
            else if (X < 0 && Y < 0)
            {
                Result = 3;
            }
            else
            {
                Result = 4;
            }

            return Result;
        }

        public static int[] SortAscendingOrder3(int X, int Y, int Z)
        {
            int tmp;
            int[] Result = new int[3];

            while (X > Y || Y > Z || Z < X)
            {
                if (X > Y)
                {
                    tmp = X;
                    X = Y;
                    Y = tmp;
                }
                else if (X > Z)
                {
                    tmp = Y;
                    Y = Z;
                    Z = tmp;
                }
                else if (Z < X)
                {
                    tmp = Z;
                    Z = X;
                    Z = tmp;
                }
            }

            Result[0] = X;
            Result[1] = Y;
            Result[2] = Z;

            return Result;
        }

        public static double[] SolutionQuadraticEquation4(int X, int Y, int Z)
        {
            int tmp;
            double[] Result = new double[2];

            tmp = Y * Y - 4 * X * Z;

            if (tmp<0)
            {
                throw new Exception ("недопустимое значение Корней нет");
            }

            Result[0] = (-Y + MathF.Sqrt(tmp)) / (2 * X);
            Result[1] = (-Y - MathF.Sqrt(tmp)) / (2 * X);

            return Result;
        }

        public static string NumbersInWords(int X)
        {
            string Result;
            string[] Numbers = new string[10] { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] Numbers1 = new string[10] { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестьнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
            string[] Numbers2 = new string[10] { "","","двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };

            if (X<10)
            {
                throw new Exception("недопустимое значение, X<10");
            }
            int tmp = X % 10;
            int tmp1 = X / 10;

            if (X < 20)
            {
                Result = $"{Numbers1[tmp]}";
            }else
            {
                Result = $"{Numbers2[tmp1]} {Numbers[tmp]}";
            }

            return Result;
        }
    }
}
