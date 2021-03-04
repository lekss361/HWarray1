using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    public static class Variable
    {
        public static void PrintInfoTask()
        {
            string[] InfoTask = new string[5]
            { "1. Пользователь вводит 2 числа (A и B). Выведите в консоль решение",
              "2. Пользователь вводит 2 значения(A и B). Поменяйте содержимое переменных A и B местами.",
              "3. Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.",
              "4. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.",
              "5. Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки."
            };

            for (int i = 0; i < InfoTask.Length; i++)
            {
                Console.WriteLine(InfoTask[i]);
            }
        }

        public static int ExampleSolution1(int X, int Y)
        { 
            return (5 * X + Y * Y) / (Y - X);
        }

        public static int[] SwapVariables2(int X,int Y)
        {
            int tmp = X;
            X = Y;
            Y = tmp;
            int[] Result = new int[2] { X, Y };
            return Result;
        }

        public static double[] DivisionResidueVariables(int X, int Y)
        {
            double[] Result = new double[2] { X/Y, X%Y };
            return Result;
        }

        public static double LinearEquationSolution(int X, int Y, int Z)
        {
            return (Z - Y) / X;
        }

        public static string EquationStraight(int X, int Y, int Z, int Q)
        {
            int tmp1 = (Y - Q) / (X - Z);
            int tmp2 = Q - tmp1 * Z;
            return $"{tmp1}x+{tmp2}";
        }
    }
}
