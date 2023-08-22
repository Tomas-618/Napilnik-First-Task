namespace Napilnik
{
    public class Bot
    {
        private readonly Player _target;
        private readonly Weapon _weapon;

        private Stack<Clip> _clips;

        public Bot()
        {
            _target = new Player();
            _weapon = new Weapon();
            _clips = CreateClips();
        }

        public void OnSeePlayer()
        {
            while (_weapon.CanFire)
                _weapon.Fire(_target);
        }

        public void ReloadGun() =>
            _weapon.Reload(_clips.Pop());

        private Stack<Clip> CreateClips()
        {
            uint bulletsCount = 49;

            int minClips = 5;
            int maxClips = 10;

            int clipsCount = UserUtils.GetRandomNumber(minClips, maxClips);

            var clips = new Stack<Clip>();

            for (int i = 0; i < clipsCount; i++)
                clips.Push(new Clip(bulletsCount));

            return clips;
        }
    }
}
