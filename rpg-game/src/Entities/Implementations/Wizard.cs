using RpgGame.Entities.Interfaces;

namespace RpgGame.Entities.Implementations
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, int currentHP, int maxHP, 
            int currentMagicPower, int maxMagicPower) 
                : base(name, level, HeroType.WIZARD, currentHP, maxHP, 
                    currentMagicPower, maxMagicPower) {}

        public override void Attack()
        {
            Console.WriteLine($"{this.Name} lançou magia");
        }

        public override void Attack(int bonusDamage)
        {
            Console.WriteLine($"{this.Name} lançou magia com um bônus de {bonusDamage}");
        }
    }
}