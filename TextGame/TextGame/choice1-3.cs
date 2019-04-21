using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    class choice1_3
    {
        public void choice3()
        {
            Console.WriteLine("You being to walk, it's plain to you that this won't be a short walk, the land before you is flat, with forest as far as you can see.\n" +
                                      "As you walk you begin to realize it's pretty late in the day, and it's starting to get cold.");
            choices();
        }
        public void choices()
        {
            while (true)
            {
                int userInput = Int32.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    break;
                }
                if (userInput == 2)
                {
                    break;
                }
                if (userInput == 3)
                {
                    break;
                }
            }
        }
    }
}
