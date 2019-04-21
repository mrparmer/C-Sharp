using System;
using System.IO;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TextGame();
        }
        public static void TextGame() {
            PlayerClass player = new PlayerClass();
            choice1_1 Choice1 = new choice1_1();
            choice1_2 Choice2 = new choice1_2();
            choice1_3 Choice3 = new choice1_3();

            Console.WriteLine("Hello welcome to the world, here you will find friends, monsters, treasure, and intrigue.\n" +
                "You will be provided choices, choose which one you wish to proceed with carefully, if you fail in your quest you will have to begin again.");

            string playerName;
            Console.WriteLine("Let us begin by having you tell me your name adventurer.");
            playerName = Console.ReadLine();

            Console.WriteLine("Welcome to Aluriat " + playerName);
            Console.WriteLine(playerName + " has " + player.ToString() + " to start with. As you adventure you will get into battles, " +
                             "\ndon't forget to rest after each or your health won't regenerate." +
                             "\nYou will also find powerful items that will increase your health, watch out for those!\n");

            Console.WriteLine("The story begins;\n" +
                              "You wake up, alone, on a lonely beach, with no memory of how you got there. It's starting to get cold.\n" +
                              "What do you do?\n");

            Console.WriteLine("1. Take stock of your surroundings, and what you have on you, or what you can find nearby.\n" +
                              "2. Shout and see if anyone is around.\n" +
                              "3. Begin walking, looking for signs of people.\n");

            while (true)
            {
                int userInput = Int32.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    Choice1.choice1();
                    player.Exertion();
                    break;
                }
                else if (userInput == 2)
                {
                    Choice2.choice2();
                    break;
                }
                else if (userInput == 3)
                {
                    Choice3.choice3();
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please select a valid choice.");                    
                }

            }
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
