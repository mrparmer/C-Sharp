using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value to add");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
