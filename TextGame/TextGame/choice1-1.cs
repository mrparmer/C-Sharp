﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    public class choice1_1
    {
        int playerHealth;
        
    PlayerClass player = new PlayerClass();
        public void choice1()

            //player choice, takes stock of surroundings.
        {
            Console.WriteLine("You have exerted yourself, you now have " + player.Exertion() + " health\n" +
                              "**************************************\n" +
                              "You look around you and notice that there are no footprints leading to where you were laying,\n" +
                              "there are no sticks, shells, there is nothing. \n" +
                              "You pat yourself down and discover you are wearing nothing but a thin overshirt, and light pants.\n" +
                              "It's starting to get cold.\n" +
                              "What do you do?\n" +
                              "1. Scream for help.\n" +
                              "2. Start walking.\n" +
                              "3. Stand still, calm your breathing, and listen.");
        
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
                    Console.WriteLine("You yell. You shout until you are hoarse, and no one is answering you, you are well and truly alone.\n" +
                                      "What do you do now?");
                    choice1();
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("You are exerting yourself, you have " + player.Exertion() + " health\n" +
                                      "You being to walk, it's plain to you that this won't be a short walk, the land before you has a slight rise, \n" +
                                      "you know that this will make the journey tiring, with forest as far as you can see to both sides of you.\n" +
                                      "As you walk you begin to realize it's pretty late in the day, and it's starting to get cold.\n " +
                                      "What do you do now?\n" +
                                      "1. Continue walking, keeping a steady pace.\n" +
                                      "2. Start running, it's getting cold, the exertion should keep you warmer.\n" +
                                      "3. Succumb to the inevitable, there is no escape, sit down and wait for the cold.");

                    break;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("As your pulse calms, your breathing slows, and you focus on the sounds around you, you think you hear the sound of heavy foot steps prowling closer.\n" +
                                      "They are still a little ways away, for now.\n" +
                                      "What do you do now?\n " +
                                      "1. Panic, run, hope it doesn't catch you.\n" +
                                      "2. Remain calm, look for a hiding place, anywhere to disappear.\n" +
                                      "3. Stand and fight.");
                    break;
                }
                else if (userInput == 4) {
                    Console.WriteLine("You have rest for an hour. You hear a noise coming from behind you, you are being hunted.");
                    player.PlayerRest(player.health);
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please select a valid choice.");

                }

            }
        }

        public void choices_2()
        {

        }
    }
}
