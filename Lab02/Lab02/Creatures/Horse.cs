using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Creatures
{
    public class Horse : ICreatures
    {
        public void Drive()
        {
            Console.WriteLine("Герой передвигается на лошади");
        }
    }
}
