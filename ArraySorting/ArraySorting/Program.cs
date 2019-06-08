using System;

namespace ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            AscAlpha();
            DesAlpha();
        }

        static void AscAlpha()
        {
            char[] alphabet = new char[6] { 'a', 'd', 'b', 'c', 'f', 'e' };
            Array.Sort(alphabet);
            foreach (char i in alphabet) Console.WriteLine(i + " ");
            Console.ReadLine();
        }

        static void DesAlpha()
        {
            char[] alphabet = new char[] { 'a', 'd', 'b', 'c', 'f', 'e' };
            Array.Sort(alphabet);
            Array.Reverse(alphabet);
            foreach (char i in alphabet) Console.WriteLine(i + " ");
            Console.ReadLine();
        }

        

    }
}
