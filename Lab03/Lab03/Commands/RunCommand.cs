using Lab01.Heros;

namespace Lab03.Commands
{
    public class RunCommand : Command
    {
        Hero hero;

        public RunCommand(Hero _hero)
        {
            hero = _hero;
        }

        public override void Execute()
        {
            hero.Run();
        }
    }
}
