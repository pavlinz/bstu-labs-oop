using Lab01.Actions;

namespace Lab01
{
    public class EquestrianEnemyFactory : EnemyFactory
    {
        public override Attack CreateAttack()
        {
            return new Spear();
        }

        public override Movement CreateMovement()
        {
            return new HorseMovement();
        }
    }
}
