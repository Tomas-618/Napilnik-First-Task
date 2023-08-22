namespace Napilnik
{
    public class Clip
    {
        private readonly uint _maxBullets;

        private List<Bullet> _bullets;

        public Clip(uint bulletsCount)
        {
            _maxBullets = 49;
            _bullets = CreateBullets(bulletsCount);
        }

        public int BulletsCount => _bullets.Count;

        public Bullet GetBullet()
        {
            if (BulletsCount == 0)
                throw new InvalidOperationException();

            Bullet bullet = _bullets[BulletsCount - 1];

            _bullets.Remove(bullet);
            return bullet;
        }

        private List<Bullet> CreateBullets(uint bulletsCount)
        {
            List<Bullet> bullets = new List<Bullet>();

            if (bulletsCount > _maxBullets)
                throw new InvalidOperationException();

            for (int i = 0; i < bulletsCount; i++)
                bullets.Add(new Bullet());

            return bullets;
        }
    }
}
