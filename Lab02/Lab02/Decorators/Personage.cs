using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Decorators
{
    public abstract class Personage
    {
        public string Name { get; protected set; }

        public Personage(string _name)
        {
            this.Name = _name;
        }
    }
}
