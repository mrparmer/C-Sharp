using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.Write("Welcome " + name);
            Console.Write("\nWhat is your age? ");
            var age = Console.ReadLine();
            Console.WriteLine("\n\tName:\tAge:");
            Console.WriteLine("\t{0} \t{1}", name, age);
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey(true);


        }
    }
}
