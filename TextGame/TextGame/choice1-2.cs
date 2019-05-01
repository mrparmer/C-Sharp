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
            Console.Clear();
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
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.Clear();
                Console.WriteLine("You spend the next few minutes looking for anything you can use to keep warm, but on a quick inspection there is nothing, this beach is devoid of anything " +
                                  "useful.\n" +
                                  "You are running out of day light, and the tide is coming in, what do you do now?");
            }
            else if (userInput == 2)
            {
                Console.Clear();
                Console.WriteLine("You begin to walk, it's obvious that this won't be a short walk, the land before you is flat, with forest as far as you can see.\n" +
                                  "As you walk you begin to realize it's pretty late in the day, and it's getting colder by the minute.\n " +
                                  "What do you do now?");
            }
            else if (userInput == 3)
            {
                Console.Clear();
                Console.WriteLine("You lay down, curl into the fetal position and succumb to the cold. Not long after, the beast finds you, nothing remains.");
            }
            else if (userInput == 4)
            {
                Console.WriteLine("You rest for an hour. You hear a noise coming from behind you, you are being hunted.");
                player.PlayerRest(player.health);
                Console.WriteLine("What do you do now?\n" +
                                  "1. Look for materials to build a fire, or something to at least hold off the cold.\n" +
                                  "2. Start walking, hoping you will come across someone, or at the very least the exertion will keep you warm.\n" +
                                  "3. Feel sorry for yourself, and stay put.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That is not a valid choice, please select a valid choice.\n" +
                                  "Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("What do you do now?\n" +
                                  "1. Look for materials to build a fire, or something to at least hold off the cold.\n" +
                                  "2. Start walking, hoping you will come across someone, or at the very least the exertion will keep you warm.\n" +
                                  "3. Feel sorry for yourself, and stay put.");
            }
        }
    }
}
