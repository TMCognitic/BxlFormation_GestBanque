using System;

namespace Models
{
    public abstract class Compte : ICustomer, IBanker
    {
        public static double operator +(double soldePrecedant, Compte courant)
        {
            return ((soldePrecedant < 0) ? 0 : soldePrecedant) + ((courant.Solde < 0) ? 0 : courant.Solde);
        }

        public event PassageEnNegatifDelegate PassageEnNegatifEvent;

        private string _numero;
        private double _solde;
        private Personne _titulaire;

        public string Numero
        {
            get
            {
                return _numero;
            }

            private set
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

            private set
            {
                _titulaire = value;
            }
        }

        public Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
        }

        public Compte(string numero, Personne titulaire, double solde)
            : this(numero, titulaire)
        {
            Solde = solde;
        }

        public void Depot(double montant)
        {
            if (!(montant > 0))
            {
                throw new ArgumentOutOfRangeException(nameof(montant), "La valeur doit être supérieure à 0!");
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
                throw new ArgumentOutOfRangeException(nameof(montant), "La valeur doit être supérieure à 0!");
            }

            if (Solde - montant < -ligneDeCredit)
            {
                throw new SoldeInsuffisantException("Solde insuffisant!!");
            }

            Solde -= montant;
        }

        protected abstract double CalculInteret();

        public void AppliquerInterer()
        {
            Solde += CalculInteret(); //Pattern Template Method
        }

        protected void RaisePassageEnNegatifEvent()
        {
            PassageEnNegatifEvent?.Invoke(this);
        }
    }
}