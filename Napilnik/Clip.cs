namespace Napilnik
{
    public class Clip
    {
        private readonly uint _maxBullets;
        private Queue<Bullet> _bullets;

        public Clip(uint bulletsCount)
        {
            _maxBullets = 49;
            _bullets = CreateBullets(bulletsCount);
        }

        public int GetBulletsCount() =>
            _bullets.Count;

        public void Fire(IDamageable target) =>
            _bullets.Dequeue().Attack(target);

        private Queue<Bullet> CreateBullets(uint bulletsCount)
        {
            var bullets = new Queue<Bullet>();

            if (bulletsCount > _maxBullets)
                throw new InvalidOperationException();

            for (int i = 0; i < bulletsCount; i++)
                bullets.Enqueue(new Bullet());

            return bullets;
        }
    }
}
