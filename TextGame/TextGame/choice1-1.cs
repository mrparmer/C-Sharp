using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    public class choice1_1
    {
        PlayerClass player = new PlayerClass();
        public void choice1()
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
                              "3. Stand still, calm your breathing, and listen.\n" +
                              "4. Rest.");

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
                    Console.WriteLine("You being to walk, it's plain to you that this won't be a short walk, the land before you is flat, with forest as far as you can see.\n" +
                                      "As you walk you begin to realize it's pretty late in the day, and it's starting to get cold.\n " +
                                      "What do you do now?");
                    break;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("As your pulse calms, your breathing slows, and you focus on the sounds around you, you think you hear the sound of foot steps approaching.\n" +
                        "They are still a little ways away, for now.\n" +
                        "What do you do now?");
                    break;
                }
                else if (userInput == 4) {
                    Console.WriteLine("How long do you wish to rest for?");
                    int restDuration = Int32.Parse(Console.ReadLine());
                    player.PlayerRest(restDuration);

                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please select a valid choice.");

                }

            }
        }
    }
}
