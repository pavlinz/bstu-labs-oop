using Lab01.Heros;

namespace Lab03.State
{
    public class RunningState : HeroState
    {
        public void HandleInput(Hero hero, char symb)
        {
            if (symb == 'w')
                hero.ChangeState(new RunningState());
            if (symb == 'q')
                hero.ChangeState(new JumpingState());
        }

        public override string ToString()
        {
            return "Состояние бега";
        }
    }
}
