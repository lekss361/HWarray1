using System;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 4, 2, 3, 1,5 };
            array1 = ArrayRank1.BackwardHalfArray_8(array1);
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} ;");
            }
           
            


            int[,] array = new int[3,5];

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

           array= ArrayRank2.BackwardMainDiagonalArray_6(array);

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
