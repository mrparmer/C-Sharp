using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    public class PlayerClass
    {
        int health;
        string name;

        public PlayerClass() {
          health = 100;
        }

        public override string ToString()
        {
            return health + " health ";
        }
    }
}
