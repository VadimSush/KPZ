namespace Builder.Builders
{
    public interface IBuilder
    {
        public IBuilder AddHeight(int height);

        public IBuilder AddHairColor(string hairColor);

        public IBuilder AddEyesColor(string eyesColor);

        public IBuilder AddPhysique(string physique);

        public IBuilder AddWeapon(string weapon);

        public IBuilder AddGold(int gold);

        public IBuilder AddHealth(int health);
    }
}
