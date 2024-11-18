using System;

namespace TheGun
{
    public struct Bullet
    {
        public Bullet(int damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(damage.ToString());

            Damage = damage;
        }

        public int Damage { get; }
    }
}
