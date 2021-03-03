using System;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3,3];

            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = random.Next(0, 100);
                    Console.Write($"{i},{j}:{array[i,j]} ");
                }
                Console.WriteLine();
            }
               
            Console.WriteLine("////////////");
            Console.WriteLine($"dlina{array.Length}rank{array.Rank}");
            Console.WriteLine($"{HW2Array.MinOfArray1(array)}{HW2Array.MaxOfArray2(array)}");
            Console.WriteLine($"{HW2Array.IndexMinOfArray3(array)}{HW2Array.IndexMaxOfArray4(array)}");
            Console.WriteLine($"{HW2Array.NumberMoreNeighbors5(array)}");
            Console.WriteLine($"{array.GetLength(0)}{array.GetLength(1)}");
            array = HW2Array.BackwardMainDiagonalArray(array);
            Console.WriteLine("////////////");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{i},{j}:{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
