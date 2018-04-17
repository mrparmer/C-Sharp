using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>();
            List<int> payList = new List<int>();
            List<int> hoursList = new List<int>();

            while (true)
            {
                Console.Write("Do you want to (A)dd, or E(x)it? ");
                string userInput = Console.ReadLine();
                string upperUserInput = userInput.ToUpper();

                if (upperUserInput == "A")
                {
                    Console.Write("Name of the new Employee? ");
                    string name = Console.ReadLine();
                    namesList.Add(name);

                    Console.Write("Pay rate? ");
                    int payRate = Convert.ToInt32(Console.ReadLine());
                    payList.Add(payRate);

                    Console.Write("How many hours did they work? ");
                    int hoursWorked = Convert.ToInt32(Console.ReadLine());
                    hoursList.Add(hoursWorked);

                    int payOwed = payRate * hoursWorked;

                    Console.WriteLine("Pay owed: " + payOwed);
                }

                if (upperUserInput == "X")
                {
                    Environment.Exit(0);
                    break;
                }
                else
                {
                    Console.WriteLine("Unknown Command");
                }
            }
        }
    }
}
