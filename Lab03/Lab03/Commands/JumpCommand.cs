using Lab01.Heros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
