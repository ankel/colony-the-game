using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace colony
{
    class Colony
    {
        public String Name;
        internal Economy eco;

        public Colony()
        {
            eco = new Economy();
            Name = "New colony";
        }

        public void ResourceTick()
        {
            eco.Tick();
        }
    }
}
