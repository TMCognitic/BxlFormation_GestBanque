using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Courant : Compte
    {
        private double _ligneDeCredit;

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

        public override void Retrait(double montant)
        {
            Retrait(montant, LigneDeCredit);
        }
    }
}
