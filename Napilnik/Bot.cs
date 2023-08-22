namespace Napilnik
{
    public class Bot
    {
        private readonly Player _target;
        private readonly Weapon _weapon;

        public Bot()
        {
            _target = new Player();
            _weapon = new Weapon(5, 49);
        }

        public void OnSeePlayer() =>
            _weapon.Fire(_target);
    }
}
