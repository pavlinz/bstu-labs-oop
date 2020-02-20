using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Heros
{
    public class Director
    {
        public Hero create(HeroBuilder Builder)
        {
            Builder.CreateHero();
            Builder.SetArmor();
            Builder.SetWeapon();
            Builder.SetProfession();
            return Builder.hero;
        }
    }
}
