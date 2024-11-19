using System;

namespace TheGun
{
    public class Bot
    {
        private readonly RangedWeapon _weapon;

        public Bot(RangedWeapon weapon) =>
            _weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));

        public void OnSeePlayer(Health player)
        {
            if (player.IsDied)
                return;

            _weapon.Shoot(player);
        }
    }
}
