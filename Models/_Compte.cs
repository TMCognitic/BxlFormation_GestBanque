//Implémentation du 4ème exercice des interfaces

using System;

namespace Models
{
    public abstract class _Compte : ICustomer, _IBanker
    {
        public static double operator +(double soldePrecedant, _Compte courant)
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

        public virtual double LigneDeCredit
        {
            get { return 0D; }
            set { return; /*à remplacer par une erreur asap.*/ }
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
            if (!(montant > 0))
            {
                Console.WriteLine("montant invalide!!");
                return; //à remplacer par une erreur asap.
            }

            if (Solde - montant < -LigneDeCredit)
            {
                Console.WriteLine("Solde insuffisant!!");
                return; //à remplacer par une erreur asap.
            }

            Solde -= montant;
        }

        protected abstract double CalculInteret();

        public void AppliquerInterer()
        {
            Solde += CalculInteret(); //Pattern Template Method
        }
    }
}