using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public abstract class EnemyFactory
    {
        public abstract Movement CreateMovement();
        public abstract Attack CreateAttack();
    }
}
