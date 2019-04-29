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
            Console.Clear();
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
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.Clear();
                Console.WriteLine("The exertion does help relieve the creeping cold from your limbs, however, the exertion has cost you, you haven't eaten in a long time, and are growing weak.\n" +
                "You now have "+ player.Exertion() + " health\n" +
                "As you run, you make a lot of noise. This seems to draw the attention of something in the forest, you start to here heavy footsteps in the forest, and the sound of breaking branches.\n" +
                "You can't keep this up for long, what do you do?");
            }
            if (userInput == 2)
            {
                Console.Clear();
                Console.WriteLine("The exertion does help relieve the creeping cold from your limbs, however, the exertion has cost you, you haven't eaten in a long time, and are growing weak.\n" +
                "You now have " + player.Exertion() + " health\n" +
                "You run along the beach, this keeps the sound of your footsteps quiet, but the added exertion of running through loose sand means you have to work harder and your breathing quickly\n" +
                "labored. You can't keep this up for long.\n" +
                "What do you do?");
            }
            if (userInput == 3)
            {
                Console.Clear();
                Console.WriteLine("The exertion does help relieve the creeping cold from your limbs, however, the exertion has cost you, you haven't eaten in a long time, and are growing weak.\n" +
                "You now have " + player.Exertion() + " health\n" + 
                "");
            }
            else if (userInput == 4)
            {
                Console.Clear();
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
