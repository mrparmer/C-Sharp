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
        static double pay;
        static List<string> nameList = new List<string>();
        static List<double> hoursList = new List<double>();
        static List<double> wagesList = new List<double>();
        

        static void Main(string[] args)
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

            double pay = wage * hours;

            Console.WriteLine(name + "'s pay should equal " + pay);
            Console.WriteLine("Employees");
            nameList.ForEach(Console.WriteLine);
            Console.ReadLine();
        }

        static void lists(string[] args)
        {
            
        }

        static void input(string[] args)
        {
           
        }

       
    }
}
