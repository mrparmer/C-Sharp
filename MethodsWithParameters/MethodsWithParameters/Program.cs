using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(Add(1, 2), Add(3, 4))); //unlikely usage
            Console.WriteLine(Add(15, 31));

            Console.WriteLine(Multply(55, 32));

            Console.WriteLine(Divide(6, 4));
            Console.Read();

        }

        public static int Add(int num1, int num2)
        {
          return num1 + num2; ;
        }

        public static int Multply(int num1, int num2)
        {
            return num1 * num2; ;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
