using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Banque
    {
        private Dictionary<string, Compte> _comptes = new Dictionary<string, Compte>();
        public string Nom { get; private set; }

        public Banque(string nom)
        {
            Nom = nom;
        }

        public Compte this[string numero]
        {
            get { return _comptes[numero]; }
        }

        public void Ajouter(Compte compte)
        {
            _comptes.Add(compte.Numero, compte);
            compte.PassageEnNegatifEvent += PassageEnNegatifAction;
        }        

        public void Supprimer(string numero)
        {
            Compte compte = this[numero];
            compte.PassageEnNegatifEvent -= PassageEnNegatifAction;
            _comptes.Remove(numero);
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double total = 0D;

            foreach (Compte compte in _comptes.Values)
            {
                if (compte.Titulaire == titulaire)
                {
                    total += compte;
                }
            }

            return total;
        }

        private void PassageEnNegatifAction(Compte compte)
        {
            Console.WriteLine($"Le compte '{compte.Numero}' vient de passer en négatif!");
        }
    }
}
