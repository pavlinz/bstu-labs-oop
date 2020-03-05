using System;
using Lab01.Heros;

namespace Lab03.State
{
    public class RunningState : HeroState
    {
        public void HandleInput(Hero hero, char symb)
        {
            hero.ChangeState(new RunningState());
        }

        public override string ToString()
        {
            return "Состояние бега";
        }
    }
}
