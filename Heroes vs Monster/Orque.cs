using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monster
{
    public class Orque :Monstres
    {
        private int _force;
        private int _loot;

        public Orque()
        {
            _loot = Or;
        }
        public int Force
        {
            get { return _force + 1; }
            set { _force = value; }
        }
    }
}
