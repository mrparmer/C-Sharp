using System;

namespace MultiplesOf3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiple = 0;
            for (int i = 0; i < 1000; i++ )
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    multiple += i;
                }
            }
            Console.WriteLine(multiple);
        }
    }
}
