using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace colony
{
    /// <summary>
    /// Reusable resource that can be managed between different goal, such as human, energy
    /// </summary>
    class ReusableResource
    {
        private colony.Growth growthRate;
        private int level;
        public long current;
        private string name;

        public long Cap
        {
            get { return this.growthRate.Linear(this.level); }
        }

        public long capCost
        {
            get { return this.growthRate.Cubic(this.level); }
        }

        public long Current
        {
            get { return this.current; }
        }

        public int Level
        {
            get { return this.level; }
        }

        public void Tick()
        {
            return;
        }

        public ReusableResource(string name, colony.Growth growthRate)
        {
            this.name = name;
            this.growthRate = growthRate;
            this.level = 1;
        }

        public string ToString()
        {
            return String.Format("{0}: {1}/{2}", this.name, this.current, this.Cap);
        }
    }
}