using RpgGame.Entities.Interfaces;
using RpgGame.Entities.Implementations;

List<Hero> heroes = new List<Hero>
{
    new Warrior("Arus", 42, 469, 749, 72, 72),
    new Ninja("Wedge", 42, 292, 574, 89, 89),
    new Wizard("Jenica", 42, 325, 601, 474, 482),
    new Wizard("Topapa", 42, 106, 385, 611, 641)
};

Console.WriteLine(string.Join("\n\n", heroes));

Console.WriteLine("\n=================================\n");

Hero? arus = heroes.Find(hero => hero.Name == "Arus");
arus?.Attack();
arus?.Attack(20);
