namespace Napilnik
{
    public class Bot
    {
        private readonly Player _target;
        private readonly Weapon _weapon;

        private List<Clip> _clips;

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

        public void ReloadGun()
        {
            if (_clips.Count == 0)
                throw new InvalidOperationException();

            Clip clip = _clips[_clips.Count - 1];

            _clips.Remove(clip);
            _weapon.Reload(clip);
        }

        private List<Clip> CreateClips()
        {
            List<Clip> clips = new List<Clip>();

            uint bulletsCount = 49;

            int minClips = 5;
            int maxClips = 10;

            int clipsCount = UserUtils.GetRandomNumber(minClips, maxClips);

            for (int i = 0; i < clipsCount; i++)
                clips.Add(new Clip(bulletsCount));

            return clips;
        }
    }
}
