using System;
using System.Collections;

namespace Lab01.Enemies
{
    public class ArmyOfEnemies
    {
        public EnemyCommander EnemyCommander { get; set; }
        public ArrayList list;

        public void AddNewEnemy(Unit unit)
        {
            list.Add(unit);
        }

        public ArmyOfEnemies()
        {
            list = new ArrayList();
            EnemyCommander.getInstance();
        }
    }
}
