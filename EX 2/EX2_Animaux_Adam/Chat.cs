using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_Animaux_Adam
{
    class Chat : Animal
    {
        public Chat(string nom, string dateNaissance, int taille, bool animalConcours, int numPuce) : base(nom, dateNaissance, taille, animalConcours, numPuce)
        {

        }
        public string Miaule()
        {
            return "Est entrain de miauler";
        }
        public string Ronronne()
        {
            return "Ronronne fort";
        }
    }
}
