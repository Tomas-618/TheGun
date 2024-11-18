namespace TheGun.Interfaces
{
    public interface IAttacker
    {
        bool CanAttack { get; }

        void Attack(IDamagable target);
    }
}
