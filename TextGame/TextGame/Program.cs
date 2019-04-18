using System;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerClass player = new PlayerClass();

            Console.WriteLine("Hello welcome to the world, here you will find friends, monsters, treasure, and intrigue.\n" +
                "You will be provided choices, choose which one you wish to proceed with carefully, if you fail in your quest you will have to begin again.");

            string playerName;
            Console.WriteLine("Let us begin by having you tell me your name adventurer.");
            playerName = Console.ReadLine();

            Console.WriteLine("Welcome to Aluriat " + playerName);
            Console.WriteLine(playerName + " has " + player.ToString() + " to start with. As you adventure you will get into battles, " +
                             "\ndon't forget to rest after each or your health won't regenerate." +
                             "\nYou will also find powerful items that will increase your health, watch out for those!\n");

            Console.WriteLine("The story begins; \n" +
                              "You wake up, alone, on a lonely beach, with no memory of how you got there. \n" +
                              "What do you do?\n");

            Console.WriteLine("(T)ake stock of your surroundings, and what you have on you. \n" +
                              "(S)hout and see if anyone is around.\n" +
                              "(B)egin walking, looking for signs of people.\n");

            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == "T")
                {
                    Console.WriteLine("You look around you and notice that there are no footprints leading to where you were laying, " +
                                      "\nthere are no sticks, shells, there is nothing. \n" +
                                      "You pat yourself down and discover you are wearing nothing but a thin overshirt, and light pants.\n" +
                                      "It's starting to get cold.\n");

                    break;
                }
                else if (userInput == "S")
                {
                    Console.WriteLine("You yell. You shout until you are hoarse, and no one is answering you, you are well and truly alone, it's starting to get cold");
                    Console.WriteLine("What do you do?");

                    break;
                }
                else if (userInput == "B")
                {
                    Console.WriteLine("You being to walk, it's plain to you that this won't be a short walk, the land before you is flat, with forest as far as you can see.\n" +
                                      "As you walk you begin to realize it's pretty late in the day, and it's starting to get cold.");

                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please select a valid choice.");
                    
                }

            }
        }

    }
}
