using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendsList = { "Derek", "Leigh", "Josh", "Kenny" }; //array to organize the list of friend allowing me to iterate through the list, and allowing for expansion later.
            int count = 0; //allows iteration through the array with the foreach function
            foreach (string i in friendsList) //runs through the array from start to finish performing the actions below.
            {
                count++; //increasing count by 1 each run through until it is unable to do so once it reaches the end of the array.
                GreetFriend($"{i}"); //calls the greetfriend method and adds the name in the spot in the array that is at the location that corresponds to what count is equal to for that round.
            }
            Console.ReadLine(); //stops the console from auto-closing once the program has reached its end allowing me to ensure the code has run correctly.
        }
        public static void GreetFriend (string friend)
        {
            Console.WriteLine("Hello, {0}, I am glad you are my friend.", friend);
        }
    }
}

