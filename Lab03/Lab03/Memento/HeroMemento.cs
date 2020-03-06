using Lab01.Heros;
using Lab03.State;

namespace Lab03.Memento
{
    public class HeroMemento
    {
        public HeroState state;
        public Armor armor { get; set; }
        public Weapon weapon { get; set; }
        public Profession profession { get; set; }

        public HeroMemento(Armor _armor, Weapon _weapon, Profession _profession, HeroState _state)
        {
            this.armor = _armor;
            this.weapon = _weapon;
            this.profession = _profession;
            this.state = _state;
        }
    }
}
