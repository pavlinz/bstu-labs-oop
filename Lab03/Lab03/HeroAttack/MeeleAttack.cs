using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.HeroAttack
{
    public class MeeleAttack : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Ближняя атака");
        }
    }
}
