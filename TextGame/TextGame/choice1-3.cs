using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    class choice1_3
    {
        int playerHealth;
       
    PlayerClass player = new PlayerClass();
        public void choice3()
        {
            Console.WriteLine("You being to walk, it's plain to you that this won't be a short walk, the land before you is flat, with forest as far as you can see.\n" +
                              "You quickly begin to realize it's pretty late in the day, and it's starting to get cold.\n " +
                              "What do you do?\n" +
                              "1. Move quickly in the direction of the trees, hoping the extertion will keep you warm.\n" +
                              "2. Move quickly to the right along the shoreline, hoping the extertion will keep you warm.\n" +
                              "3. Move quickly in the left along the shoreline, hoping the extertion will keep you warm.\n");
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
                else if (userInput == 4)
                {
                    Console.WriteLine("You have rest for an hour. You hear a noise coming from behind you, you are being hunted.");
                    player.PlayerRest(player.health);
                    choice3();
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please select a valid choice.");
                    choice3();
                }
            }
        }
    }
}
