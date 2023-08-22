namespace Napilnik
{
    public class Weapon
    {
        private Clip _clip;

        public Weapon() =>
            _clip = new Clip(49);

        public bool CanFire => _clip.GetBulletsCount() > 0;

        public void Fire(IDamageable target) =>
            _clip.Fire(target);

        public void Reload(Clip clip) =>
            _clip = clip;
    }
}
