namespace Napilnik
{
    public class Clip
    {
        private readonly uint _maxBullets;
        private Stack<Bullet> _bullets;

        public Clip(uint bulletsCount)
        {
            _maxBullets = 49;
            _bullets = CreateBullets(bulletsCount);
        }

        public int GetBulletsCount() =>
            _bullets.Count;

        public Bullet GetBullet() =>
            _bullets.Pop();

        private Stack<Bullet> CreateBullets(uint bulletsCount)
        {
            var bullets = new Stack<Bullet>();

            if (bulletsCount > _maxBullets)
                throw new InvalidOperationException();

            for (int i = 0; i < bulletsCount; i++)
                bullets.Push(new Bullet());

            return bullets;
        }
    }
}
