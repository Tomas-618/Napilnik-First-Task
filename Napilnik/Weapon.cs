namespace Napilnik
{
    public class Weapon
    {
        private readonly uint _damage;
        private uint _bulletsCount;

        public Weapon(uint bulletsCount)
        {
            _damage = 5;
            _bulletsCount = bulletsCount;
        }

        public bool CanFire => _bulletsCount > 0;

        public void Fire(IDamageable target)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            while (CanFire)
            {
                _bulletsCount--;
                target.TakeDamage(_damage);
            }
        }
    }
}
