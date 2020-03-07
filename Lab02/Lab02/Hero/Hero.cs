using System.Text;
using Lab02.Creatures;
using Lab02.Map;

namespace Lab01.Heros
{
    public class Hero : IHero, IComponent
    {
        public Armor armor { get; set; }
        public Weapon weapon { get; set; }
        public Profession profession { get; set; }
        public string Title { get; set; } = "Main Hero";

        public void Move(ICreatures creatures)
        {
            creatures.Drive();
        }

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

        public void Draw(){}

        public IComponent Find(string title)
        {
            return null;
        }
    }
}
