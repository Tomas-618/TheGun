using System;
using System.Collections.Generic;

namespace TheGun
{
    public class Magazine
    {
        private readonly Stack<Cartridge> _cartridges;
        private readonly int _maxCartridgesCount;

        public Magazine(Stack<Cartridge> cartridges, int maxCartridgesCount)
        {
            if (cartridges.Count > maxCartridgesCount)
                throw new InvalidOperationException();

            _cartridges = cartridges ?? throw new ArgumentNullException(nameof(cartridges));
            _maxCartridgesCount = maxCartridgesCount;
        }

        public bool HasMaxCartridges => _cartridges.Count == _maxCartridgesCount;

        public bool HasCartridge => _cartridges.Count > 0;

        public Bullet ReleaseBullet() =>
            _cartridges.Pop().RealiseBullet();

        public void AddBullet(Cartridge cartridge)
        {
            if (HasMaxCartridges)
                return;

            _cartridges.Push(cartridge);
        }
    }
}
