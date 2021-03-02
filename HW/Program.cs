using System;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{i}:{array[i]} ");
            }
            Console.WriteLine();
            array=HW1Array.SelectSortArray10(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i}:{array[i]} ");
            }
        }
    }
}
