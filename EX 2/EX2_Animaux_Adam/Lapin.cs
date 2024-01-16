using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_Animaux_Adam
{
     class Lapin : Animal
    {
        private int _tailleOreille;

    

        public int TailleOreille
        {
            get { return TailleOreille; }
            set { _tailleOreille = value; }
        }

        public Lapin(int tailleOreille, string nom, string dateNaissance, int taille, bool animalConcours, int numPuce) : base( nom, dateNaissance, taille, animalConcours,numPuce)
        {
            _tailleOreille = tailleOreille;
        }

        public override string Affiche()
        {
            string info = "Taille de l'oreille" + _tailleOreille;
            return info;
        }
        public string Bondir()
        {
            return "Il est entrain de bondir";
        }
    }
}
