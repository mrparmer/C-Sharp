using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    public class PlayerClass
    {
        Program randomNum = new Program();
        public int health;
        string name;
        int maxHealth = 100;
        int healthRegen;
        int strength;
        int damage;
        int dmgHealth;
        int regenedHealth;
        int restTime;
        int playerAtk;
        int exertion;
        int exhaustion;


        public int PlayerRest(int h)
        {
            if (health < maxHealth)
            {
                healthRegen = 10;                            //regen 10 health per hour rested
                health = health + healthRegen;               //sets health = to health times the number of hours the player rests.
                Console.WriteLine("You now have {0} health.", health);
                return health;
            }
            else
                return health;
            }

        public int PlayerAttack(int dmgDone)
        {
            strength = randomNum.RandomNumber(0, 10);
            dmgDone = strength * 2;
            return dmgDone;
        }

        public int Exertion()
        {
            exertion = 10;
            health = health - exertion;
            return health;
        }

        public PlayerClass()
        {
            health = 100;
            dmgHealth = health - damage;
            int newHealth = exhaustion;
        }    
    }
}
