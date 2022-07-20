using RpgGame.Entities.Interfaces;

namespace RpgGame.Entities.Implementations
{
    public class Warrior : Hero
    {
        public Warrior(string name, int level, int currentHP, int maxHP, 
            int currentMagicPower, int maxMagicPower) 
                : base(name, level, HeroType.WARRIOR, currentHP, maxHP, 
                    currentMagicPower, maxMagicPower) {}

        public override void Attack()
        {
            Console.WriteLine($"{this.Name} está atacando com uma espada");
        }

        public override void Attack(int bonusDamage)
        {
            Console.WriteLine($"{this.Name} está atacando com uma espada com um bônus de {bonusDamage}");
        }
    }
}