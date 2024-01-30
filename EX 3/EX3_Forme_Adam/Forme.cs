using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_Forme_Adam
{
     abstract class Forme
    {
        protected string _couleur;

        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public Forme(string couleur)
        {
            _couleur = couleur;
        }

        public virtual string Affiche()
        {
            string info = "Couleur" + _couleur;
            return info;
        }

        public abstract int CalculeSurface();
        public abstract int CalculePerimetre();
        





    }
}
