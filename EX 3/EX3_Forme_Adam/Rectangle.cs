using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_Forme_Adam
{
     class Rectangle : Forme
    {
        private int _longueur;
        private int _largeur;


        public int Longueur
        {
            get { return _longueur; }
            set { _longueur = value; }
        }
        public int Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }


        public  Rectangle(int longueur, int largeur, string couleur) : base(couleur)
        {
            _longueur = longueur;
            _largeur = largeur;

        }

        public override string Affiche()
        {
            string info = "Longueur" + _longueur + "Largeur" + _largeur +"Couleur" + _couleur;
            return info;
        }

        public override int CalculePerimetre()
        {
            return _longueur * _largeur * 2;

        }
        public override int CalculeSurface()
        {
            return _longueur * _largeur;
        }

    }
}
