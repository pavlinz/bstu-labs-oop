using System;
using System.Text;
using Lab02.Creatures;
using Lab02.Map;
using Lab03.State;
using Lab03.Memento;

namespace Lab01.Heros
{

    public class Hero : IHero, IComponent
    {
        private HeroState _state;

        public Armor armor { get; set; }
        public Weapon weapon { get; set; }
        public Profession profession { get; set; }
        public string Title { get; set; } = "Main Hero";

        public void HandleInput(char symbol)
        {
            _state.HandleInput(this, symbol);
        }

        public void ChangeState(HeroState state)
        {
            _state = state;
            Console.WriteLine(_state.ToString());
        }

        public void Move(ICreatures creatures)
        {
            creatures.Drive();
        }

        public void Run()
        {
            Console.WriteLine("Бег");
        }

        public void Jump()
        {
            Console.WriteLine("Прыжок");
        }

        public HeroMemento SaveState()
        {
            Console.WriteLine("Сохранение игры. Параметры: {0}, {1}, {2}, {3}", armor, weapon, profession, _state);
            return new HeroMemento(armor, weapon, profession, _state);
        }

        public void RestoreState(HeroMemento memento)
        {
            this.armor = memento.armor;
            this.weapon = memento.weapon;
            this.profession = memento.profession;
            this._state = memento.state;
            Console.WriteLine("Восстановление игры. Параметры: {0}, {1}, {2}, {3}", armor, weapon, profession, _state);
        }

        public IHero Clone()
        {
            return new Hero(this.armor, this.weapon, this.profession);
        }

        public Hero() {
            _state = new RunningState();
        }

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
