using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monster.Outils
{
    public class RollDice
    {
        private Random rnd = new Random();
        private int[] Rolls = new int[19];
        public int truc;
        public int OneDice6()
        {
            return rnd.Next(6) + 1;
        }
        public int OneDice4()
        {
            return rnd.Next(4) + 1;
        }
       
    }
}
