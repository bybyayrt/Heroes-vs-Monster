using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monster
{
    public class Humain : Heroes
    {
        private int _force;
        private int _endurance;
        public int Force
        {
            get { return _force + 1; }
            set { _force = value; }
        }
        public int Endurance
        {
            get { return _endurance + 1;}
            set { _endurance = value; }
        } 


    }
}
