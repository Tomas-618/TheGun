using System;
using TheGun.Interfaces;

namespace TheGun
{
    public class Health : IDamagable
    {
        private int _value;

        public Health(int value)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(value.ToString());

            _value = value;
        }

        public bool IsDied => _value <= 0;

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(damage.ToString());

            _value = Math.Max(0, _value - damage);
        }
    }
}
