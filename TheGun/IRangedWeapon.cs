using TheGun.Interfaces;

namespace TheGun
{
    public interface IRangedWeapon : IAttacker
    {
        void Reloud(Magazine magazine);
    }

    public class Revolver : IRangedWeapon
    {
        public bool CanAttack => ;

        public void Attack(IDamagable target)
        {

        }

        public void Reloud(Magazine magazine)
        {

        }
    }
}
