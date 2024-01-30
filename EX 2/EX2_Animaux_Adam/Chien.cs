using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_Animaux_Adam
{
     class Chien : Animal
     {
        public Chien(string nom, string dateNaissance, int taille, bool animalConcours, int numPuce) : base ( nom,  dateNaissance,  taille,  animalConcours,  numPuce)
        {

        }
        public string Aboyer()
        {
            return "Il aboie";
        }
     }
}
