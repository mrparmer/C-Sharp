using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;                                                             //Employee Name added to nameList
            double payRate;                                                          //Employee Pay Rate added to rateList
            double hoursWorked;                                                      //Integer associated with how many hours the employee worked, multiplied by payRate
            //double pay;
            bool addMore;

            List<string> nameList = new List<string>();
            List<double> rateList = new List<double>();
            List<double> hWorkedList = new List<double>();
        }

        public static object PayRollMethod(string name, double payRate, double hoursWorked, bool addMore, List<string> nameList, List<double> rateList, List<double> hWorkedList)
        {
            Console.Write("Enter employee name: ");
            name = Console.ReadLine();
            nameList.Add(name);                                                       //adds the name entered to the namesList

            Console.Write("What is the pay rate for this employee: ");
            payRate = Convert.ToDouble(Console.ReadLine());
            rateList.Add(payRate);                                                    //adds the payRate to the rateList, as a double

            Console.Write("How many hours did the employee work? ");
            hoursWorked = Convert.ToDouble(Console.ReadLine());
            hWorkedList.Add(hoursWorked);

            Console.Write("Do you need to add any other employees? Y or N");
            addMore = Convert.ToBoolean(Console.ReadLine());

            Console.ReadKey();

        }


    }
}
