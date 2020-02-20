using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Heros
{
    public abstract class HeroBuilder
    {
        public Hero hero { get; private set; }

        public void CreateHero()
        {
            hero = new Hero();
        }

        public abstract void SetArmor();
        public abstract void SetWeapon();
        public abstract void SetProfession();
    }
}
