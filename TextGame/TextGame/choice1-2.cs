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
                              "3. The weight of your situation sinks in, you are alone, cold, and hungry.  You have no obvious resources, and no recourse. You become despondent. ");
            playerHealth = player.health;

            if (playerHealth < 100)
            {
              t64xZ-78Y09  Console.WriteLine("4. Rest\n");
            }
            choices();
        }
        public void choices()
        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.Clear();
                +

                Console.WriteLine("You spend the next few minutes looking for anything you can use to keep warm, but on a quick inspection there is nothing, this beach is devoid of anything " +
                                  "useful.\n" +
                                  "You are running out of day light, and the tide is coming in, what do you do now?\n" +
                                  "1. Look for somewhere to hole up for the night, you don't know what's out here.\n" +
                                  "2. You decide to bury yourself farther up the beach, away from the water, you notice the sand is pretty warm up here, thanks to the bright direct sunlght. \n" +
                                  "You spend the night partially buried in the sane, you hear strange noises all night, but get some rest. The sun right wakes you up, what do you do not?");
            }
            else if (userInput == 2)
            {
                Console.Clear();
                Console.WriteLine("You decide that standing here, or staying put is a waste of time. You start walking. Which way do you go?\n" +
                                  "1. North, directly away from the water.\n" +
                                  "2. East, directly away from the cliff that's to the west.");
            }
            else if (userInput == 3)
            {
                Console.Clear();
                Console.WriteLine("You lay down, curl into the fetal position and succumb to the cold. Not long after, a beast finds you, nothing remains.");
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
