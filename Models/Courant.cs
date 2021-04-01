using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Courant
    {
        private string _numero;
        private double _solde;
        private double _ligneDeCredit;
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

        public double LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }

            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Ligne de crédit invalide!!");
                    return; //à remplacer par une erreur asap.
                }

                _ligneDeCredit = value;
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
            if(!(montant > 0))
            {
                Console.WriteLine("montant invalide!!");
                return; //à remplacer par une erreur asap.
            }

            Solde += montant;
        }

        public void Retrait(double montant)
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
    }
}
