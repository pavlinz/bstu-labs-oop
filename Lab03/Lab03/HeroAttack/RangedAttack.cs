using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.HeroAttack
{
    public class RangedAttack : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Дальняя атака");
        }
    }
}
