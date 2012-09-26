using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace colony
{
    interface Resource
    {
        public void Tick();
        public string ToString();
        public string Tooltip;
    }
}
