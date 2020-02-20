using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Enemies
{
    public class EnemyCommander
    {
        private static EnemyCommander instance;

        protected EnemyCommander() {}

        public static EnemyCommander getInstance() {

            if(instance == null) {
                instance = new EnemyCommander();
                Console.WriteLine("Командующий армией врагов на поле боя");
            }
            return instance;
        }
    }
}
