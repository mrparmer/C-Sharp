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
            List<string> namesList = new List<string>();                    //list that stores the names of the employees entered
            List<int> payList = new List<int>();                            //list that stores the pay rates for the employees
            List<int> hoursList = new List<int>();                          //list that stores the hours worked by the employees

            while (true)                                                    //loop for the user to input employee information, continues while until the user enters X to exit
            {
                Console.Write("Do you want to (A)dd, (P)rint lists, or E(x)it? ");         
                string userInput = Console.ReadLine();
                string upperUserInput = userInput.ToUpper();                //convert any lowercase entries into uppercase to ensure consistancy in input

                if (upperUserInput == "A")                                  //beginning of loop that will continue to allow the user to add employees to the lists
                {
                    Console.Write("Name of the new Employee? ");
                    string name = Console.ReadLine();
                    namesList.Add(name);                                    //adds entry to the appropriate list

                    Console.Write("Pay rate? ");
                    int payRate = Convert.ToInt32(Console.ReadLine());
                    payList.Add(payRate);                                   //adds entry to the appropriate list

                    Console.Write("How many hours did they work? ");
                    int hoursWorked = Convert.ToInt32(Console.ReadLine());
                    hoursList.Add(hoursWorked);                             //adds entry to the appropriate list

                    int payOwed = payRate * hoursWorked;                    //operation to figure the amount that should be paid to the employee
                    string payAmount = String.Format("Pay the employee: {0:C}", payOwed); //Converts the result of payOwed to currency

                    Console.WriteLine(payAmount);

                }

                else if (upperUserInput == "P")
                {
                    Console.WriteLine("\nEmployees: \n");
                    foreach (string element in namesList)
                    {
                        Console.WriteLine(element);
                    }
                    Console.WriteLine("\nPay Rates: \n");
                    foreach (int element in payList)
                    {
                        Console.WriteLine(element);
                    }
                    Console.WriteLine("\nHours Worked: \n");
                    foreach (int element in hoursList)
                    {
                        Console.WriteLine(element);
                    }
                    Console.WriteLine();                   
                }

                else if (upperUserInput == "X")
                {
                    Environment.Exit(0);                                    //Exits the program when the user inputs X
                    break;                                                  //breaks the While loop when the condition is met
                }
                else if (upperUserInput != "A , X, P")                          //if any character other than those specified it prints the error below
                {
                    Console.WriteLine("Unknown Command");
                }
            }
        }
    }
}
