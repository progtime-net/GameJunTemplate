using System;
using GameJun.Interfaces;

namespace GameJun.Classes
{
    public class Ilya : AbstractCharacter
    {
        Random rand = new Random();

        public Ilya()
        {
            health = 15;
            defense = 2;
            damage = 0;
        }

        public override void Attack(AbstractCharacter other)
        {
            other.Damage(damage = rand.Next(0, 5));
        }

        public override void Damage(int amount)
        {
            health -= amount - defense;
        }

        public override bool IsAlive()
        {
            if (health <= 0)
            {
                return false;
            }

            return true;
        }
    }
}



