using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Decorators
{
    public abstract class PersDecorator : Personage
    {
        protected Personage personage;

        public PersDecorator(string n, Personage personage) : base(n)
        {
            this.personage = personage;
        }
    }
}
