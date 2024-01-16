using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_Animaux_Adam
{
    class Animal
    {
        protected string _nom;
        protected string _dateNaissance;
        protected int _taille;
        protected bool _animalConcours;
        protected int _numPuce;


        public string Nom
        {
            get { return Nom; }
            set { _nom = value; }
        }

        public string DateNaissance
        {
            get { return DateNaissance; }
            set { _dateNaissance = value; }
        }


        public int Taille
        {
            get { return Taille; }
            set { _taille = value; }
        }


        public bool AnimalConcours
        {
            get { return AnimalConcours; }
        }


        public int NumPuce
        {
            get { return NumPuce; }
            set { _numPuce = value; }
        }

        public Animal(string nom, string dateNaissance, int taille, bool animalConcours, int numPuce)
        {
            _nom = nom;
            _dateNaissance = dateNaissance;
            _taille = taille;
            _animalConcours = animalConcours;
            _numPuce = numPuce;
        }

        public virtual string Affiche()
        {
            string info = "Nom" + _nom + "Date de naissance" + _dateNaissance + "Taille" + _taille + "Animal de concours ou pas" + _animalConcours + "Numéro de puce" + _numPuce;
            return info;
        }
        public string Dormir()
        {
            return "Est entrain de dormir";
        }
        public string Manger()
        {
            return "Mange";
        }
    }
}
