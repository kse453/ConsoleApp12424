using System;

namespace ConsoleApp12424
{
    class Program
    {
        static void Main()
        {
            int n = 10;
            Random r = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
                Console.Write(array[i] + " ");
            }
            int max = array[0], index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    index = i;
                }
            }
            array[index] = n;
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
        }
    }
}
