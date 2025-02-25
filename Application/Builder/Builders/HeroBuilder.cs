using Builder.Characters;

namespace Builder.Builders
{
    public class HeroBuilder : IBuilder
    {
        public HeroBuilder()
        {
            _hero = new Hero();
        }

        private Hero _hero;

        public IBuilder AddHeight(int height)
        {
            _hero.Height = height;
            return this;
        }

        public IBuilder AddHairColor(string hairColor)
        {
            _hero.HairColor = hairColor;
            return this;
        }

        public IBuilder AddEyesColor(string eyesColor)
        {
            _hero.EyesColor = eyesColor;
            return this;
        }

        public IBuilder AddPhysique(string physique)
        {
            _hero.Physique = physique;
            return this;
        }

        public IBuilder AddWeapon(string weapon)
        {
            _hero.Weapon = weapon;
            return this;
        }

        public IBuilder AddGold(int gold)
        {
            _hero.Gold = gold;
            return this;
        }

        public IBuilder AddHealth(int health)
        {
            _hero.Health = health;
            return this;
        }

        public IBuilder AddGoodDeeds(string[] goodDeeds)
        {
            _hero.GoodDeeds.AddRange(goodDeeds);
            return this;
        }

        public IBuilder AddGoodDeed(string goodDeed)
        {
            _hero.GoodDeeds.Add(goodDeed);
            return this;
        }

        public Hero GetHero()
        {
            return _hero;
        }

        public void Reset()
        {
            _hero = new Hero();
        }
    }
}
