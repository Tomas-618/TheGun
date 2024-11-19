using System;
using TheGun.Interfaces;

namespace TheGun
{
    public class RangedWeapon
    {
        private readonly IGunShootingStrategy _shootingStrategy;

        private Magazine _magazine;

        public RangedWeapon(IGunShootingStrategy shootingStrategy, Magazine magazine)
        {
            _shootingStrategy = shootingStrategy ?? throw new ArgumentNullException(nameof(shootingStrategy));
            _magazine = magazine ?? throw new ArgumentNullException(nameof(magazine));
        }

        public bool CanShoot => _magazine.HasCartridge;

        public void Shoot(IDamagable target)
        {
            if (CanShoot == false)
                throw new InvalidOperationException();

            _shootingStrategy.Shoot(target, _magazine);
        }

        public void Reloud(Magazine magazine) =>
            _magazine = magazine ?? throw new ArgumentNullException(nameof(magazine));
    }
}
