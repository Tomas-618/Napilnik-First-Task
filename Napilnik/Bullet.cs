namespace Napilnik
{
    public struct Bullet : IAttackable
    {
        private readonly uint _damage;

        public Bullet() =>
            _damage = SetDamage();

        public void Attack(IDamageable target)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            target.TakeDamage(_damage);
        }

        private uint SetDamage()
        {
            int minDamage = 5;
            int maxDamage = 20;

            return (uint)UserUtils.GetRandomNumber(minDamage, maxDamage);
        }
    }
}
