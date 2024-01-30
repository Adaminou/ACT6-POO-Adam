using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_Forme_Adam
{
     class Carre : Forme
    {
        private int _cote;
        

        public int Cote
        {
            get { return _cote; }
            set { _cote = value; }
        }


        public Carre(int cote, string couleur) : base (couleur)
        {
            _cote = cote;
       
        }

        public override string Affiche()
        {
            string info = "Côté" + _cote;
            return info;
        }

        public override int CalculePerimetre()
        {
            return _cote * 4;
        }
        public override int CalculeSurface()
        {
            return _cote * _cote;
        }

    }
}
