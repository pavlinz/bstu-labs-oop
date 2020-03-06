using Lab01.Heros;


namespace Lab03.Commands
{
    class JumpCommand : Command
    {
        Hero hero;

        public JumpCommand(Hero _hero)
        {
            hero = _hero;
        }

        public override void Execute()
        {
            hero.Jump();
        }
    }
}
