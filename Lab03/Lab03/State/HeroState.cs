using Lab01.Heros;

namespace Lab03.State
{
    public interface HeroState
    {
        void HandleInput(Hero hero, char symb);
    }
}
