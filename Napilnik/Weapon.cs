namespace Napilnik
{
    public class Weapon
    {
        private Clip _clip;

        public Weapon() =>
            _clip = new Clip(49);

        public bool CanFire => _clip.BulletsCount > 0;

        public void Fire(IDamageable target)
        {
            Bullet bullet = _clip.GetBullet();

            bullet.Attack(target);
        }

        public void Reload(Clip clip) =>
            _clip = clip;
    }
}
