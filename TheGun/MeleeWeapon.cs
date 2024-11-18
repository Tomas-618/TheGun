using TheGun.Interfaces;

namespace TheGun
{
    public class MeleeWeapon : IAttacker
    {
        public bool CanAttack { get; }

        public void Attack(IDamagable target)
        {

        }
    }
}
