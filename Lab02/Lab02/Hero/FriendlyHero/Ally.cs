using System;

namespace Lab02.Hero.FriendlyHero
{
    public class Ally : IAlly
    {
        public void Drive()
        {
            Console.WriteLine("Герой передвигается на союзном юните");
        }
    }
}
