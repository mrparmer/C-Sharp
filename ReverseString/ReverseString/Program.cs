using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a word that you want reversed.");
            string word = Console.ReadLine();
            stringReversal(word);
            Console.ReadKey();
        }
        public static string stringReversal(string str)
        {
            
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            Console.WriteLine(chars);
            return new string (chars);
            
        }
    }
}
