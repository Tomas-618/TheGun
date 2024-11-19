namespace TheGun
{
    public class Cartridge
    {
        private Bullet _bullet;

        public Cartridge(Bullet bullet) =>
            _bullet = bullet;

        public Bullet RealiseBullet()
        {
            Bullet bullet = _bullet;

            if (_bullet.IsEmpty == false)
                _bullet = _bullet.CreateVirtualPrototype();

            return bullet;
        }
    }
}
