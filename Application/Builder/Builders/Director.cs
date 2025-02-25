namespace Builder.Builders
{
    public class Director
    {
        public void BuildStrongHuman(IBuilder builder)
        {
            builder.AddHealth(1500).AddWeapon("Sword").AddHeight(185).AddEyesColor("Blue").AddHairColor("Black").AddPhysique("Very Strong");
        }

        public void BuildOtherStrongHuman(IBuilder builder)
        {
            builder.AddHealth(2000).AddWeapon("Spear").AddHairColor("Gray").AddEyesColor("Green").AddGold(10000).AddPhysique("Super Strong").AddHeight(190);
        }
    }
}
