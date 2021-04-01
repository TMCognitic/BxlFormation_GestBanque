using Models;
using System;

namespace GestBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne titulaire = new Personne()
            {
                Nom = "Morre",
                Prenom = "Thierry",
                DateNaiss = new DateTime(1974, 6, 5)
            };

            Courant courant = new Courant()
            {
                Numero = "00001",
                LigneDeCredit = 200,
                Titulaire = titulaire
            };

            courant.LigneDeCredit = -500;
            courant.Depot(-200);
            courant.Depot(500);
            courant.Retrait(-100);
            courant.Retrait(701);
            courant.Retrait(700);

            Console.WriteLine($"le solde du compte {courant.Numero} est : {courant.Solde}");

        } 
    }
}
