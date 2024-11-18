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

        public bool IsDied { get; private set; }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(damage.ToString());

            _value -= damage;

            if (_value > 0)
                return;

            _value = 0;
            IsDied = true;
        }
    }
}
