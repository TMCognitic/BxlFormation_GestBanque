using System;

namespace Models
{
    public class Personne
    {       
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public DateTime DateNaiss { get; private set; }

        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = dateNaiss;
        }
    }
}
