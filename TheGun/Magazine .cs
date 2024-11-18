using System;
using System.Collections.Generic;

namespace TheGun
{
    public class Magazine
    {
        private readonly Stack<Bullet> _bullets;
        private readonly int _maxCartridgesCount;

        public Magazine(Stack<Bullet> bullets, int maxCartridgesCount)
        {
            if (bullets.Count > maxCartridgesCount)
                throw new InvalidOperationException();

            _bullets = bullets ?? throw new ArgumentNullException(nameof(bullets));
            _maxCartridgesCount = maxCartridgesCount;
        }

        public bool HasMaxBullets => _bullets.Count == _maxCartridgesCount;

        public bool HasBullets => _bullets.Count > 0;

        public Bullet ReleaseBullet() =>
            _bullets.Pop();

        public void AddBullet(Bullet bullet)
        {
            if (HasMaxBullets)
                return;

            _bullets.Push(bullet);
        }
    }
}
