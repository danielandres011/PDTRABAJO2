using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.COMPOSITE
{
    public abstract class AmarreComponent
    {
        public abstract void Add(AmarreComponent amarreComponent);
        public abstract void Remove(AmarreComponent amarreComponent);
        public abstract void ShowInfo();
    }
}
