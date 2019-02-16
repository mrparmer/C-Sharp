using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an arguement, and am called from a method");
            Console.Read();
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);     
         }
    }
}
