using Lab02.Creatures;

namespace Lab02.Hero.FriendlyHero
{
    public class AllyAdapter : ICreatures
    {
        Ally ally;

        public AllyAdapter(Ally _ally)
        {
            ally = _ally;
        }

        public void Drive()
        {
            ally.Drive();
        }
    }
}
