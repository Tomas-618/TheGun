namespace TheGun.Interfaces
{
    public interface IGunShootingStrategy
    {
        void Shoot(IDamagable target, Magazine magazine);
    }
}
