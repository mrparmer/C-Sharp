using System;

namespace DistanceConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            float miles;
            const int feetInMile = 5280;
            const int inchesInMile = 63360;
            Console.WriteLine("How many miles do you wish to convert?");
            miles = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2} miles = {1} feet.", miles, miles * feetInMile);

            Console.WriteLine("{0:F2} miles = {1} inches", miles, miles * inchesInMile);
            Console.ReadKey();
        }
    }
}
