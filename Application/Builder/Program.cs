using Builder.Builders;
using Builder.Characters;

HeroBuilder heroBuilder = new HeroBuilder();
EnemyBuilder enemyBuilder = new EnemyBuilder();

Director director = new Director();

director.BuildStrongHuman(heroBuilder);
heroBuilder.AddGoodDeeds(["Saved the child", "Defeated the goblin"]).AddGold(5000);
Hero hero = heroBuilder.GetHero();

director.BuildOtherStrongHuman(enemyBuilder);
enemyBuilder.AddBadDeed("Killed a man");
Enemy enemy = enemyBuilder.GetEnemy();

Console.WriteLine($"Hero's weapon: {hero.Weapon}, hero's height: {hero.Height}, hero's good deeds: {string.Join(", ", hero.GoodDeeds)}");
Console.WriteLine($"Enemy's eyes color: {enemy.EyesColor}, enemy's gold: {enemy.Gold}, enemy's bad deeds: {string.Join(", ", enemy.BadDeeds)}");