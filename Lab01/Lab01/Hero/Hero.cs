using Lab01.Heros;
using System.Text;

namespace Lab01.Heros
{
    public class Hero : IHero
    {
        public Armor armor { get; set; }
        public Weapon weapon { get; set; }
        public Profession profession { get; set; }

        public IHero Clone()
        {
            return new Hero(this.armor, this.weapon, this.profession);
        }

        public Hero() { }

        public Hero(Armor _armor, Weapon _weapon, Profession _profession)
        {
            armor = _armor;
            weapon = _weapon;
            profession = _profession;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (armor != null)
                sb.Append(armor.TypeOfArmor + "\n");
            if (weapon != null)
                sb.Append(weapon.TypeOfWeapon +"\n");
            if (profession != null)
                sb.Append(profession.profession + "\n");
            return sb.ToString();
        }
    }
}
