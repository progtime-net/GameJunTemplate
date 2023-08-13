using System;
using GameJun.Interfaces;

namespace GameJun.Classes
{
    public class Archer : AbstractCharacter
    { 

        public Archer()
        {
            health = 10;
            defense = 3;
            damage = 4;
        }

        public override void Attack(AbstractCharacter other)
        {
            other.Damage(damage);
        }

        public override void Damage(int amount)
        {
            health -= amount - defense;
        }

        public override bool IsAlive()
        {
            if(health <= 0)
            {
                return false;
            }

            return true;
        }
    }
}

