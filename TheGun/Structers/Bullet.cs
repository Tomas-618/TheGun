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
            IsEmpty = false;
        }

        private Bullet(int damage, bool isVirtual)
        {
            Damage = damage;
            IsEmpty = isVirtual;
        }

        public int Damage { get; }

        public bool IsEmpty { get; }

        public Bullet CreateVirtualPrototype() =>
            new Bullet(Damage, IsEmpty);
    }
}
