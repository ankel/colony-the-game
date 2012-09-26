using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace colony
{
    class Economy
    {
        internal SimpleResource Metal, Crystal, Energy;

        public Economy()
        {
            Metal = new SimpleResource("Metal", 500, 1000, 30);
            Crystal = new SimpleResource("Crystal", 500, 1000, 20);
            Energy = new SimpleResource("Energy", 500, 1000, 10);
        }

        /// <summary>
        /// Signal the end of a day, increase all resources value
        /// </summary>
        public void Tick()
        {
            Metal.Tick();
            Crystal.Tick();
            Energy.Tick();
        }
    }
}
