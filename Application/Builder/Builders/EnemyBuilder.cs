using Builder.Characters;

namespace Builder.Builders
{
    public class EnemyBuilder : IBuilder
    {
        public EnemyBuilder()
        {
            _enemy = new Enemy();
        }

        private Enemy _enemy;

        public IBuilder AddHeight(int height)
        {
            _enemy.Height = height;
            return this;
        }

        public IBuilder AddHairColor(string hairColor)
        {
            _enemy.HairColor = hairColor;
            return this;
        }

        public IBuilder AddEyesColor(string eyesColor)
        {
            _enemy.EyesColor = eyesColor;
            return this;
        }

        public IBuilder AddPhysique(string physique)
        {
            _enemy.Physique = physique;
            return this;
        }

        public IBuilder AddWeapon(string weapon)
        {
            _enemy.Weapon = weapon;
            return this;
        }

        public IBuilder AddGold(int gold)
        {
            _enemy.Gold = gold;
            return this;
        }

        public IBuilder AddHealth(int health)
        {
            _enemy.Health = health;
            return this;
        }

        public IBuilder AddBadDeeds(string[] badDeeds)
        {
            _enemy.BadDeeds.AddRange(badDeeds);
            return this;
        }

        public IBuilder AddBadDeed(string badDeed)
        {
            _enemy.BadDeeds.Add(badDeed);
            return this;
        }

        public Enemy GetEnemy()
        {
            return _enemy;
        }

        public void Reset()
        {
            _enemy = new Enemy();
        }
    }
}
