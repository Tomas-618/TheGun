using System;
using TheGun.Interfaces;

namespace TheGun
{
    public class Bot
    {
        private readonly IAttacker _weapon;

        public Bot(IAttacker weapon) =>
            _weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));

        public void OnSeePlayer(Health player)
        {
            if (player.IsDied)
                return;

            _weapon.Attack(player);
        }
    }
}
