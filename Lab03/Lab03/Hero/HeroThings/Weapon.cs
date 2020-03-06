using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Heros
{
    public class Weapon
    {
        public string TypeOfWeapon { get; set; }


        public override string ToString()
        {
            return TypeOfWeapon;
        }
    }
}
