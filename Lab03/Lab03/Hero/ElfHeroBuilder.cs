using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Heros
{
    class ElfHeroBuilder : HeroBuilder
    {
        public override void SetArmor()
        {
            this.hero.armor = new Armor { TypeOfArmor = "Тяжелая броня" };
        }

        public override void SetProfession()
        {
            this.hero.profession = new Profession { profession = "Кузнец" };
        }

        public override void SetWeapon()
        {
            this.hero.weapon = new Weapon { TypeOfWeapon = "Двухручный топор" };
        }
    }
}
