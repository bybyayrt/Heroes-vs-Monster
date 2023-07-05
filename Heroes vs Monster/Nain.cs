using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monster
{
    public class Nain : Heroes
    {
        private int _endurance;

        public int Endurance
        { 
            get 
            { 
                return _endurance+2; 
            }
            set 
            {
                _endurance = value;
            }
        }
    }
}
