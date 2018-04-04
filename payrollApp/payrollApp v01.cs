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

        static void input(string[] args)
        {
            Console.WriteLine("What is employees name?");
            name = Console.ReadLine();
            Console.WriteLine("What was " + name + " hours worked?");
            hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pay rate for " + name + "?");
            wage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hi");
        }
        static void lists(string[] args)
        {
            List<string> names = new List<string>();
            List<int> hoursWorked = new List<int>();
            List<int> payRate = new List<int>();
        }
    }
}
