using Lab01.Actions;

namespace Lab01
{
    public class FootEnemyFactory : EnemyFactory
    {
        public override Attack CreateAttack()
        {
            return new Ax();
        }

        public override Movement CreateMovement()
        {
            return new FootMovement();
        }
    }
}
