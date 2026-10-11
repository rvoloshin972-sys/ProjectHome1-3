using System;
namespace ProjectHome2
{
    internal class Program
    {
        static bool IsPalindrome(int number) 
        {
            string text = Math.Abs((long)number).ToString();
            string reversed = "";
            for (int i = text.Length - 1; i >= 0; i--) 
            {
                reversed += text[i];
            }
            return text == reversed;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть число: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.WriteLine(IsPalindrome(number));
        }
    }
}
