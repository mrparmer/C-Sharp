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
                "\nYou will also find powerful items that will increase your health, watch out for those!");
        }
    }
}
