using Heroes_vs_Monster.Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monster
{
    public class Monstres : Personnage
    {

        private int _or;
        private int _cuir;
        private RollDice rol = new RollDice();
        public Monstres()
        {
            
            _or = rol.OneDice6();
            _cuir = rol.OneDice4();
        }
        public int Or
        {
            get { return _or; }
            set { _or = value; }
        }
        public int Cuir
        {
            get { return _cuir; }
            set { _cuir = value; }
        }
        

    }
}
