using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_v4
{
    class Program
    {
        private string name;
        private string payRate;
        private double hours;
        private double totalPay;

        public void Person (string n, string pr, double hr)
        {
            name = n;
            payRate = pr;
            hours = hr;
        }

        static void Main(string[] args)
        {
           List<Person> employee = new List<Person>();
            
        }
    }

    
}
