using Lab01.Actions;

namespace Lab01.Enemies
{
    public class Unit
    {
        private Attack _attack;
        private Movement _movement;

        public Unit(EnemyFactory factory)
        {
            _attack = factory.CreateAttack();
            _movement = factory.CreateMovement();
        }

        public string Move()
        {
            return _movement.Move();
        }

        public string Hit()
        {
            return _attack.Hit();
        }

        public override string ToString()
        {
            return this.Move() + " " + this.Hit();
        }
    }
}
