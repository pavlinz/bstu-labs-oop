using System;
using Lab01.Heros;

namespace Lab03.State
{
    public class JumpingState : HeroState
    {
        public void HandleInput(Hero hero, char symb)
        {
            hero.ChangeState(new JumpingState());
        }

        public override string ToString()
        {
            return "Состояние прыжка";
        }
    }
}
