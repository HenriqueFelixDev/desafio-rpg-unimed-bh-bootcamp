namespace RpgGame.Entities.Interfaces
{
    public interface IAttacker
    {
        public void Attack();
        public void Attack(int bonusDamage);
    }
}