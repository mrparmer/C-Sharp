using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    class Monster
    {
        Program randomNum = new Program();
        int health;
        int strength;
        double dmgDone;
        public void MonsterStats()
        {
            strength = randomNum.RandomNumber(0, 10);
            health = randomNum.RandomNumber(50, 100);
        }
        public int Attack(int damage)
        {
            dmgDone = strength * 1.5;
            dmgDone = damage;
            return damage;
        }
        public static void MonsterClass()
        {

        }
    }
}
