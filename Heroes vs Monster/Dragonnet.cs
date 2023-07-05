using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monster
{
    public class Dragonnet : Monstres
    {
        private int _endurance;
        private int _loot;
       // private Monstres _loot = new Monstres();
        public Dragonnet()
        {
            _loot = Or + Cuir;
        }
        public int Endurance
        {
            get { return _endurance + 1; }
            set { _endurance = value; }
        }
    }
}
