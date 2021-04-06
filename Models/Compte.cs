using System;

namespace Models
{
    public class Compte
    {
        public static double operator +(double soldePrecedant, Compte courant)
        {
            return ((soldePrecedant < 0) ? 0 : soldePrecedant) + ((courant.Solde < 0) ? 0 : courant.Solde);
        }

        private string _numero;
        private double _solde;
        private Personne _titulaire;

        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public double Solde
        {
            get
            {
                return _solde;
            }

            private set
            {
                _solde = value;
            }
        }

        public Personne Titulaire
        {
            get
            {
                return _titulaire;
            }

            set
            {
                _titulaire = value;
            }
        }
        public void Depot(double montant)
        {
            if (!(montant > 0))
            {
                Console.WriteLine("montant invalide!!");
                return; //à remplacer par une erreur asap.
            }

            Solde += montant;
        }

        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0D);
        }

        protected void Retrait(double montant, double ligneDeCredit)
        {
            if (!(montant > 0))
            {
                Console.WriteLine("montant invalide!!");
                return; //à remplacer par une erreur asap.
            }

            if (Solde - montant < -ligneDeCredit)
            {
                Console.WriteLine("Solde insuffisant!!");
                return; //à remplacer par une erreur asap.
            }

            Solde -= montant;
        }
    }
}