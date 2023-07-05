using Heroes_vs_Monster.Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monster
{
    public class Personnage
    {
        private int _endurance;
        private int _force;
        private int _death;
        private int _pointDeVie;
        private RollDice roll = new RollDice();
        public Personnage()
        {
            _endurance = roll.OneDice6() + roll.OneDice6() + roll.OneDice6();
            _force = roll.OneDice6() + roll.OneDice6() + roll.OneDice6();
            if (_endurance < 5)
            {
                
                _pointDeVie = _endurance-1;
            }
            else if (_endurance < 10)
            {
                 
                _pointDeVie = _endurance;
            }
            else if (_endurance < 15)
            {
                
                _pointDeVie = _endurance+1;
            }
            else
            {
                
                _pointDeVie = _endurance+2;
            }            
        }

        
        public int Endurance
        {
            get
            {
                return _endurance;
            }
            set
            {
                 _endurance = value;
            }
        }

        public int Force
        {
            get 
            {
                return _force; 
            }  
            set
            {
                _force = value;
            }
        }
        public int Death { get; set; } = 0;
        public int PointDeVie
        {
            get { return (_pointDeVie); }
            set 
            {if (value <= 0)
                {
                    _pointDeVie = Death;
                }
            else
                    _pointDeVie= value; 
            }
        }

        public void Frappe(Personnage cible)
        {
            int degats;
            if (_force < 5)
            {

               degats = roll.OneDice4() - 1;
            }
            else if (_force < 10)
            {

                degats = roll.OneDice4();
            }
            else if (_force < 15)
            {

                degats = roll.OneDice4() + 1;
            }
            else
            {

                degats = roll.OneDice4() + 2;
            }

            cible.PointDeVie -= degats;
        }
    }
}
