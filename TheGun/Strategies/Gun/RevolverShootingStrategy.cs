namespace TheGun.Interfaces
{
    public class RevolverShootingStrategy : IGunShootingStrategy
    {
        public void Shoot(IDamagable target, Magazine magazine)
        {
            Bullet bullet = magazine.ReleaseBullet();

            if (bullet.IsEmpty)
                return;

            target.TakeDamage(bullet.Damage);
        }
    }
}
