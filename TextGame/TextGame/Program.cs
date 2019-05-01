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

            Console.WriteLine("Hello welcome to the world, it's a harsh unforgiven world. You are being hunted, time is short.\n" +
                "You will be provided choices, choose which one you wish to proceed with carefully, if you fail in your quest you will have to begin again.");

            string playerName;
            Console.WriteLine("Let us begin by having you tell me your name adventurer.");
            playerName = Console.ReadLine();

            Console.WriteLine("Welcome to Aluriat " + playerName);
            Console.WriteLine("You have " + player.health + " health to start with. As you move through this world, you will exert yourself, which causes you to lose health, you can rest, but, \n" +
                              "resting means you are still, and the monster will get closer." +
                              "\nResting is the only way to regain health however, so be wise in your choices.");

            Console.WriteLine("The story begins;\n" +
                              "You wake up, alone, on a sandy beach, with no memory of how you got there. The sun is setting it's starting to get cold.\n" +
                              "What do you do?\n");

            Console.WriteLine("1. Take stock of your surroundings, and what you have on you, or what you can find nearby.\n" +
                              "2. Shout and see if anyone is around.\n" +
                              "3. Begin walking, looking for signs of life.\n");

                int userInput = Int32.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    Choice1.choice1();
                }
                else if (userInput == 2)
                {
                    Choice2.choice2();
                }
                else if (userInput == 3)
                {
                    Choice3.choice3();
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please select a valid choice.");                    
                }
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public static void loseCondition()
        {
            Console.WriteLine("You were consumed by the beast. \n" +
                "Start again?\n" +
                "Y to begin again\n" +
                "N to exit");
            char userInput = Console.Read();
            if (userInput == Y)
            {
                Console.Clear();
                TextGame();
            }
            if (userInput == N)
            {
                Environment.Exit(0);
            }
        }
    }

}
