using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Epargne : Compte
    {
        private DateTime _dateDernierRetrait;

        public DateTime DateDernierRetrait
        {
            get
            {
                return _dateDernierRetrait;
            }

            private set
            {
                _dateDernierRetrait = value;
            }
        }

        public override void Retrait(double montant)
        {
            double oldSolde = Solde;
            base.Retrait(montant);

            if (Solde != oldSolde)
            {
                DateDernierRetrait = DateTime.Now;
            }
        }

        protected override double CalculInteret()
        {
            return Solde * .045;
        }
    }
}
