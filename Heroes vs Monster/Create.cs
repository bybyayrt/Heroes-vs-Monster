using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monster
{
    public static class Create
    {
        public static void CreatePersonnage(Monstres m)
        {
            
                
        }

        public static Dragonnet Dragonnet()
        {
            Dragonnet drag = new Dragonnet();
            CreatePersonnage(drag);
            return drag;
        }
        public static Loup Loup()
        {
            Loup loup = new Loup();
            CreatePersonnage(loup);
            return loup;
        }
        public static Orque Orque()
        {
            Orque orq = new Orque();
            CreatePersonnage(orq);
            return orq;
        }

    }
}
