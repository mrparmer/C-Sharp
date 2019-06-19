using System;

namespace Unit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversionSelection();
        }
        static void ConversionSelection()
        {
            Console.WriteLine("What units are you wanting to convert?\n" +
                "1. Emperial to Metric\n" +
                "2. Metric to Emperial");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
            {
                ToEmperial.C();
            }
            else if (selection == 2)
            {
                Console.WriteLine("Selected 2");
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please enter a valid choice");
                Console.ForegroundColor = ConsoleColor.White; ConversionSelection();
            }
            Console.ReadLine();
        }
    }
    class ToEmperial
    {
       static int conversion(int one, int two)
        {
             
            int result;
            return result;
        }
    }
    class ToMetric
    {
        static int conversion(int one, int two)
        {
            int result;
            return result;
        }
    }

}
