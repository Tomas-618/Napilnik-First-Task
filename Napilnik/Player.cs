namespace Napilnik
{
    public class Player : IReadOnlyPlayer, IDamageable
    {
        private readonly int _maxHealth;
        private int _health;

        public Player()
        {
            _maxHealth = 100;
            _health = _maxHealth;
        }

        public int Health
        {
            get => _health;
            private set
            {
                if (value <= 0)
                    _health = 0;
                else if (value >= _maxHealth)
                    _health = _maxHealth;
                else
                    _health = value;
            }
        }

        public void TakeDamage(uint damage) =>
            Health -= (int)damage;
    }
}
