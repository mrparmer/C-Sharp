using System;

namespace Unit_Conversion
{
    public class Program
    {

        static void Main(string[] args)
        {
            ConversionSelection();
        }
        static void ConversionSelection()
        {
            ToEmperial ToEmp = new ToEmperial();
            ToMetric ToMet = new ToMetric();

            Console.WriteLine("What units are you wanting to convert?\n" +
                "1. Emperial to Metric\n" +
                "2. Metric to Emperial");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
            {
                ToEmp.conversion();
            }
            else if (selection == 2)
            {
                ToMet.conversion();
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
    public class ToEmperial
    {
        public void conversion()
        {
            Console.WriteLine("What unit do you want to convert to?\n" +
                "1. Millimeters to Inches\n" +
                "2. Meters to Feet\n" +
                "3. Kilometers to Miles\n" +
                "4. Grams to Ounces\n" +
                "5. Kilograms to Pounds");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
            {
                Console.WriteLine("How many millimeters do you want to convert to inches?");
                int number = Convert.ToInt32(Console.ReadLine());
                double converted = number * 0.0393701;
                string unit = "inches";
                Console.WriteLine(converted + " " + unit);
                Console.WriteLine();
                conversion();
            }
            else if (selection == 2)
            {
                Console.WriteLine("How many meters do you want to convert to feet?");
                int number = Convert.ToInt32(Console.ReadLine());
                double converted = number * 3.28084;
                string unit = "feet";
                Console.WriteLine(converted + " " + unit);
            }
            else if (selection == 3)
            {
                Console.WriteLine("How many kilometers do you want to convert to miles?");
                int number = Convert.ToInt32(Console.ReadLine());
                double converted = number * 0.621371;
                string unit = "miles";
                Console.WriteLine(converted + " " + unit);
            }
            else if (selection == 4)
            {
                Console.WriteLine("How many grams do you want to convert to ounces?");
                int number = Convert.ToInt32(Console.ReadLine());
                double converted = number * 0.035274;
                string unit = "ounces";
                Console.WriteLine(converted + " " + unit);
            }
            else if (selection == 5)
            {
                Console.WriteLine("How many kilograms do you want to convert to pounds?");
                int number = Convert.ToInt32(Console.ReadLine());
                double converted = number * 2.20462;
                string unit = "pounds";
                Console.WriteLine(converted + " " + unit);
            }
            else
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter a valid selection.");
                Console.BackgroundColor = ConsoleColor.Black;
                conversion();

            }
        }
    }
    class ToMetric
    {
        static void conversion()
        {
            Console.WriteLine("What unit do you want to convert to?\n" +
                "1. INches to Millimeters\n" +
                "2. Feet to Meters\n" +
                "3. Miles to Kilometers\n" +
                "4. Ounces to Grams\n" +
                "5. Pounds to Kilograms");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
            {
                Console.WriteLine("How many Inches to convert to Millimeters?");
                int number = Convert.ToInt32(Console.ReadLine());
                double converted = number * .393701;
                string unit = " millimeters";
                Console.WriteLine(converted + unit);
            }
            else if (selection == 2)
            {
                Console.WriteLine("How many Feet to convert to Meters?");
                int number = Convert.ToInt32(Console.ReadLine());
                double converted = number * .3048;
                string unit = " meters";
                Console.WriteLine(converted + unit);
            }
            else if (selection == 3)
            {
                Console.WriteLine("How many Miles to convert to Kilometers?");
                int number = Convert.ToInt32(Console.ReadLine());
                double converted = number * 1.60934;
                string unit = " meters";
                Console.WriteLine(converted + unit);
            }
            else if (selection == 4)
            {
                Console.WriteLine("How many Ounces to convert to Grams?");
                int number = Convert.ToInt32(Console.ReadLine());
                double converted = number * 28.3495;
                string unit = " grams";
                Console.WriteLine(converted + unit);
            }
            else if (selection == 5)
            {
                Console.WriteLine("How many Pounds to convert to Kilograms?");
                int number = Convert.ToInt32(Console.ReadLine());
                double converted = number * .453592;
                string unit = " kilograms";
                Console.WriteLine(converted + unit);
            }
            else
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter a valid selection.");
                Console.BackgroundColor = ConsoleColor.Black;
                conversion();
            }
        }
    }

}
