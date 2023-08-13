using System;
using GameJun.Interfaces;

namespace GameJun.Classes
{
    public class Ivan : AbstractCharacter
    {

        public Ivan()
        {
            health = 20;
            defense = 1;
            damage = 5;
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
            if (health <= 0)
            {
                return false;
            }

            return true;
        }
    }
}





