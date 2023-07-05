using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monster
{
    public class Heroes : Personnage
    {
        private string _nom;
        private int _depouille;
        private int _reposent;

        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
            }
        }
        public void Depouille()
        {
            
        }
        public void Reposent()
        {

        }
    }
}
    
