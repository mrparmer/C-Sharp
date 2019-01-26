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
            List<decimal> payTotal = new List<decimal>();
           

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
                    string payAmount = string.Format("Pre tax income: {0:C}", payOwed); //Converts the result of payOwed to currency
                    Console.WriteLine(payAmount);

                    Console.Write("Tax to deduct?");
                    decimal tax = Convert.ToDecimal(Console.ReadLine());
                    decimal taxOperation = payOwed - (payOwed * tax);
                    string taxTotal = string.Format("Pay to employee: {0:C}", taxOperation);
                    Console.WriteLine(taxTotal);
                    payTotal.Add(taxOperation);
                }

                else if (upperUserInput == "P")                             //implentation of the print option
                {
                    Console.WriteLine("\nEmployee: ");
                    foreach (string element in namesList)                   //loop to print entries in the corresponding list
                    {
                        Console.WriteLine(element);
                    }
                    Console.WriteLine("\nPay Rate: ");           
                    foreach (int element in payList)                        //loop to print entries in the corresponding list
                    {
                        Console.WriteLine(element);
                    }
                    Console.WriteLine("\nHours Worked: ");
                    foreach (int element in hoursList)                      //loop to print entries in the corresponding list
                    {
                        Console.WriteLine(element);
                    }
                    Console.Write("\nPay Total: ");
                    foreach (int element in payTotal)                        //loop to print entries in the corresponding list
                    {
                        string wageTotal = string.Format("\n{0:C}", element);
                        Console.WriteLine(wageTotal);
                    }
                    Console.WriteLine();                                    //adds an empty line after printing the hours list, so the values of the list, and the options prompt are more readable
                }

                else if (upperUserInput == "X")
                {
                    Environment.Exit(0);                                    //Exits the program when the user inputs X
                    break;                                                  //breaks the While loop when the condition is met
                }
                else if (upperUserInput != "A , X, P")                      //if any character other than those specified it prints the error below
                {
                    Console.WriteLine("Unknown Command");
                }
            }
        }
    }
}
