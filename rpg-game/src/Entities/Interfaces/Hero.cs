using RpgGame.Entities.Implementations;

namespace RpgGame.Entities.Interfaces
{
    public abstract class Hero : IAttacker
    {
        public Hero(string name, int level, HeroType heroType, 
            int currentHP, int maxHP, int currentMagicPower, int maxMagicPower)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.CurrentHP = currentHP;
            this.MaxHP = maxHP;
            this.CurrentMagicPower = currentMagicPower;
            this.MaxMagicPower = maxMagicPower;
        }

        public Hero(
            string name, int level, HeroType heroType, int maxHP, int maxMagicPower
        ) : this(name, level, heroType, maxHP, maxHP, maxMagicPower, maxMagicPower) {}

        public string Name { get; set; }

        public int Level { get; set; }

        public HeroType HeroType { get; set; }
        
        public int CurrentHP { get; set; }

        public int MaxHP { get; set; }

        public int CurrentMagicPower { get; set; }

        public int MaxMagicPower { get; set; }

        public abstract void Attack();
        
        public abstract void Attack(int bonusDamage);

        public override string ToString()
        {
            return $"Hero(Name: {Name}, Level: {Level}, HeroType: {HeroType}, " +
                    $"CurrentHP: {CurrentHP}, MaxHP: {MaxHP}, " +
                    $"CurrentMagicPower: {CurrentMagicPower}, " +
                    $"MaxMagicPower: {MaxMagicPower})";
        }
    }
}