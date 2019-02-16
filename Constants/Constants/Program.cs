using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    class Program
    {
        //constants as fields
        const double Pi = 3.14159265359;
        const int week = 52, months = 12;

        // Create a constant of type string with you birthday as a value
        const string birthday = "April 29, 1986";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be {0}", birthday);
            Console.ReadKey();
        }
    }
}
