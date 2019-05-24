using System;
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
            playerHealth = player.health;
            Console.WriteLine("You look around you and notice that there are no footprints leading to where you were laying,\n" +
                              "there are no sticks, shells, there is nothing. \n" +
                              "You pat yourself down and discover you are wearing nothing but a thin overshirt, and light pants with no pockets.\n" +
                              "It's starting to get cold.\n" +
                              "What do you do?\n" +
                              "1. Scream for help.\n" +
                              "2. Start walking.\n" +
                              "3. Stand still, calm your breathing, and listen.");           

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
                Console.WriteLine("You yell. You shout until you are hoarse, and no one is answering you, you are well and truly alone.\n" +
                                  "There is no one here, all you managed to do was attract the attention of something in the woods, it's coming this way.\n" +
                                  "What do you do now?\n" +
                                  "1. Run into the water, maybe it will lose you in the waves. The water is frigid.\n" +
                                  "2. There... There... is a monster?!?\n" +
                                  "3. Attempt to bury yourself in the sand.");
                choices1_1();

            }
            else if (userInput == 2)
            {
                Console.WriteLine("You are exerting yourself, you have " + player.Exertion() + " health\n" +
                                  "You begin to walk, it's plain to you that this won't be a short walk, the land before you has a slight rise, \n" +
                                  "you know that this will make the journey tiring, with forest as far as you can see to both sides of you.\n" +
                                  "As you walk you begin to realize it's pretty late in the day, and it's starting to get cold.\n " +
                                  "What do you do now?\n" +
                                  "1. Continue walking, keeping a steady pace.\n" +
                                  "2. Start running, it's getting cold, the exertion could keep you warmer.\n" +
                                  "3. Succumb to the inevitable, there is no escape, sit down and wait for the cold.");
                if (playerHealth < 100)
                {
                    Console.WriteLine("4. Rest\n");
                }
                choices1_2();
            }
            else if (userInput == 3)
            {
                Console.WriteLine("As your pulse calms, your breathing slows, and you focus on the sounds around you, you think you hear the sound of heavy foot steps prowling closer.\n" +
                                  "They are still a little ways away, for now.\n" +
                                  "What do you do now?\n " +
                                  "1. Panic, run, hope it doesn't catch you.\n" +
                                  "2. Remain calm, look for a hiding place, anywhere to disappear.\n" +
                                  "3. Stand and fight.");
                choices1_3();
            }
            else if (userInput == 4)
            {
                Console.WriteLine("You have rested for an hour. You hear a noise in the distance, it's coming from behind you, you are being hunted.");
                player.PlayerRest(player.health);
            }
            else
            {
                Console.WriteLine("That is not a valid choice, please select a valid choice.");
                Console.Clear();
                choices();
            }

        }

        public void choices1_1()
        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("The water is so cold, before you even make it under the water your teeth start to chatter, and you start shivering, this is not a survivable option.\n" +
                                  "What do you do?\n" +
                                  "1. Get out of the water. Get ready to fight.\n" +
                                  "2. Get out of the water and run.\n" +
                                  "3. Tough it out, surely it won't take long for the beast to lose interest.");
                choices1_1_1();
            }
            else if (userInput == 2)
            {
                Console.WriteLine("There is a beast here, and it is hunting you, this moment of fear and hesitation costs you dearly, the beast is nearly upon you.\n" +
                                  "What do you do?\n" +
                                  "1. Ready yourself to fight.\n" +
                                  "2. Make peace with your maker, and wait for the inevitable.");
                choices1_1_2();
            }
            else if (userInput == 3)
            {
                Console.WriteLine("You are exerting yourself, you have " + player.Exertion() + " health\n" +
                                  "You fall to the sand and start to dig, you get yourself covered in sand, the just slight dampness of the sand makes it easy to keep a hole, just large enough to breathe through, open.\n" +
                                  "You are completely hidden from sight, you hear the beast get closer and closer, then, for a moment all is quiet, then the beast is upon you, you weren't buried deep enough and it found you\n" +
                                  "you are concious as it begins to consume you.");
                Program.loseCondition();
            }       
            else
            {
                Console.WriteLine("That is not a valid choice, please select a valid choice.");
            }
        }
        public void choices1_2()
        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("You are walking deeper into the forest, it's getting tougher to continue, but not too difficult, the exertion is wearing your energy reserves thin.\n " + player.Exertion() +" \nEventually you" +
                    "find a decent size stick on the ground, it's sturdy, and tough. The beast is still pursueing you. \n" +
                    "What do you do?\n" +
                    "1. Pick up the stick. Find some place to hide, and wait for the monster to get closer\n" +
                    "2. Pick up the stick, use it as a walking stick, to save energy, and to help clear the brush from your path, to make your passage easier to navigate.\n" +
                    "3. Don't take the time to pick up the stick, you don't have time for that.\n");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Running, plus being absolutely petrified, warms you up, but you are quickly tiring. The beast has heard you, the increased pace has caused you to be easier to track, the monster is coming for you.\n" +
                    "You are getting tired " + player.Exertion() + "\nWhat do you do now?\n" +
                    "1.\n" +
                    "2.\n" +
                    "3.\n");
            }
            if (userInput == 3)
            {
                Console.WriteLine("You are weak, you lack the spirit to continue, and because of that weakness you are caught by the beast, and die a terrible death.");
                Program.loseCondition();
            }
            else if (userInput == 4)
            {
                Console.WriteLine("You rest for an hour. You hear a noise coming from behind you, you are being hunted.");
                player.PlayerRest(player.health);
                choices1_2();
            }
            else
            {
                Console.WriteLine("That is not a valid choice, please select a valid choice.");
                
            }
        }
        public void choices1_3()
        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("1");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("2");
            }
            else if (userInput == 3)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("That is not a valid choice, please select a valid choice.");
            }
        }
        public void choices1_1_1()
        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("You get out of the water, dripping, shivering, you look up out of the water, towards the beach, there you see a beast that baffles the mind. At almost the same moment that you see the \n" +
                    "the beast it sees you, and before you have a chance to even inhale to scream, the beast is upon you, and you are no more.");
                Program.loseCondition(); 
            }
            else if (userInput == 2)
            {
                Console.WriteLine("You burst up from beneath the waves, your lips are blue, teeth chattering, muscles shivering. You look towards shore, there you see a beast that baffles the mind. At almost the same moment that you see the \n" +
                    "the beast it sees you, and before you have a chance to even inhale to scream, the beast is upon you, and you are no more.");
                Program.loseCondition();
            }
            else if (userInput == 3)
            {
                Console.WriteLine("You freeze...");
                Program.loseCondition();
            }
            else
            {
                Console.WriteLine("That is not a valid choice, please select a valid choice.");
            }
        }
        public void choices1_1_2()
        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("You turn toward the sound of the sound of approaching footsteps. You square your stance, ball your fists, and ready yourself to face the unknown.");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("You kneel, bow your head, and prepare to take your last breath. Death is inevitable, for you, it comes sooner than you were hoping.");
            }            
            else
            {
                Console.WriteLine("That is not a valid choice, please select a valid choice.");
            }
        }
        
        public void choices1_2_1()

        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("1");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("2");
            }
            else if (userInput == 3)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("That is not a valid choice, please select a valid choice.");
            }
        }
        public void choices1_2_2()
        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("1");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("2");
            }
            else if (userInput == 3)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("That is not a valid choice, please select a valid choice.");
            }
        }
        public void choices1_2_3()
        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("1");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("2");
            }
            else if (userInput == 3)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("That is not a valid choice, please select a valid choice.");
            }
        }
    }
}


