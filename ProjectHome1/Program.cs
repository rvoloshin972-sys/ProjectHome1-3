using System;
namespace ProjectHome1
{
    internal class Program
    {
        static void PrintSquare(int side, char symbol) 
        {
            for (int i = 0; i < side; i++) 
            {
                for (int j = 0; j < side; j++) 
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть довжину сторони квадрата: ");
            int side = int.Parse(Console.ReadLine()!);

            Console.Write("Введіть символ: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();
            PrintSquare(side, symbol);
        }
    }
}
