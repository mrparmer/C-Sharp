using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    class choice1_2         
    {
        int playerHealth;

        PlayerClass player = new PlayerClass();

        public void choice2()
        {
            Console.WriteLine("You have exerted yourself, you now have " + player.Exertion() + " health\n" +
                              "**************************************\n" +
                              "You yell. You shout until you are hoarse, and no one is answering you, you are well and truly alone, it's starting to get cold");
            Console.WriteLine("What do you do?\n" +
                              "1. Look for materials to build a fire, or something to at least hold off the cold.\n" +
                              "2. Start walking, hoping you will come across someone, or at the very least the exertion will keep you warm.\n" +
                              "3. Feel sorry for yourself, and stay put.");
            playerHealth = player.health;

            if (playerHealth < 100)
            {
                Console.WriteLine("4. Rest\n");
            }
            choices();
        }
        public void choices()
        {
            while (true)
            {
                int userInput = Int32.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    Console.WriteLine("You spend the next few minutes looking for anything you can use to keep warm, but there is nothing, these beach is devoid of anything " +
                        "useful.\n" +
                        "You are running out of day light, and the tide is coming in, what do you do now?");
                    break;
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("You being to walk, it's plain to you that this won't be a short walk, the land before you is flat, with forest as far as you can see.\n" +
                                      "As you walk you begin to realize it's pretty late in the day, and it's getting colder by the minute.\n " +
                                      "What do you do now?");
                    break;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("You lay down, curl into the fetal position and succumb to the cold. Not long after the beast finds you, nothing remains.");
                    Environment.Exit(0);
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("How long do you wish to rest for?");
                    int restDuration = Int32.Parse(Console.ReadLine());
                    player.PlayerRest(restDuration);
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please select a valid choice.");
                    choice2();
                }

            }
        }
    }
}
