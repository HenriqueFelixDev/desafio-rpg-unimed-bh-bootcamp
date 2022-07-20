using RpgGame.Entities.Interfaces;

namespace RpgGame.Entities.Implementations
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, int currentHP, int maxHP, 
            int currentMagicPower, int maxMagicPower) 
                : base(name, level, HeroType.NINJA, currentHP, maxHP, 
                    currentMagicPower, maxMagicPower) {}

        public override void Attack()
        {
            Console.WriteLine($"{this.Name} está atacando com uma espada samurai");
        }

        public override void Attack(int bonusDamage)
        {
            Console.WriteLine(
                $"{this.Name} está atacando com uma espada samurai com um bônus de {bonusDamage}");
        }
    }
}