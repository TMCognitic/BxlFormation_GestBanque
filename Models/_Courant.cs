//Implémentation du 4ème exercice des interfaces

using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class _Courant : _Compte
    {
        private double _ligneDeCredit;

        public override double LigneDeCredit
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

        protected override double CalculInteret()
        {
            return Solde * ((Solde < 0) ? .0975 : .03);
        }
    }
}
