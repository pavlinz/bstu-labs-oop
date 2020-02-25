using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Decorators
{
    public class ExtraArmorPers : PersDecorator
    {
        public ExtraArmorPers(Personage p)
        : base(p.Name + " c  дополнительной броней", p)
        { }
    }
}
