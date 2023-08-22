namespace Napilnik
{
    public struct Bullet : IAttackable
    {
        private readonly uint _damage;

        public Bullet() =>
            _damage = 5;

        public void Attack(IDamageable target)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            target.TakeDamage(_damage);
        }
    }
}
