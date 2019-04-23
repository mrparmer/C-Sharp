using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    public class PlayerClass
    {
        Program randomNum = new Program();
        int health;
        string name;
        int maxHealth;
        int healthRegen;
        int strength;
        int damage;
        int dmgHealth;
        int regenedHealth;
        int restTime;
        int playerAtk;
        int exertion;
        int exhaustion;

        public int PlayerHealth(int hp)
        {
            health = hp;
            return health;
        }

        public int PlayerRest(int restTime)
        {
            healthRegen = 10;                            //regen 10 health per hour rested
            regenedHealth = restTime * healthRegen;      //formula for regenerating health as the player rests.
            regenedHealth = health;
            Console.WriteLine("You now have {0} health.", health );
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
            exhaustion = health - exertion;
            return exhaustion;
        }

        public PlayerClass()
        {
            health = 100;
            dmgHealth = health - damage;
            int newHealth = exhaustion;
        }    
        public override string ToString()
        {
            return health + " health ";
        }
    }
}
