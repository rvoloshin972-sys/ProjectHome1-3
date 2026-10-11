using System;
namespace ProjectHome3
{
    internal class Program
    {
        static int FilterArray(ref int[] originalArray, int[] filterArray) 
        {
            int deletions = 0;
            int count = 0;
            int[] result = new int[originalArray.Length];
            for (int i = 0; i < originalArray.Length; i++) 
            {
                bool found = false;
                for (int j = 0; j < filterArray.Length; j++) 
                {
                    found |= originalArray[i] == filterArray[j];
                }
                result[count] = originalArray[i];
                count += !found ? 1 : 0;
                deletions += found ? 1 : 0;
            }
            Array.Resize(ref result, count);
            originalArray = result;
            return deletions;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };

            Console.WriteLine("Оригінальний масив:");
            Console.WriteLine(string.Join(" ", originalArray));

            Console.WriteLine("\nМасив для фільтрації:");
            Console.WriteLine(string.Join(" ", filterArray));

            int deletions = FilterArray(ref originalArray, filterArray);

            Console.WriteLine("\nМасив після фільтрації:");
            Console.WriteLine(string.Join(" ", originalArray));

            Console.WriteLine("\nКількість видалень: " + deletions);
        }
    }
}
