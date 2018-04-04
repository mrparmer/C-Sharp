using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp1
{
    class Program
    {
        static string name;
        static double wage;
        static double hours;

        static void Main(string[] args)
        {

        }

        static void lists(string[] args)
        {
            List<string> nameList = new List<string>();
            List<double> hoursList = new List<double>();
            List<double> WageList = new List<double>();
        }

        static void input(string[] args)
        {
            Console.WriteLine("What is employees name?");
            name = Console.ReadLine();
            nameList.Add(name);
            Console.WriteLine("What was " + name + " hours worked?");
            hours = Convert.ToDouble(Console.ReadLine());
            hoursList.Add(hours);
            Console.WriteLine("Pay rate for " + name + "?");
            wage = Convert.ToDouble(Console.ReadLine());
            wagesList.Add(wage);
        }


    }
}
