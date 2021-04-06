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

            Epargne epargne = new Epargne()
            {
                Numero = "00002",
                Titulaire = titulaire
            };

            Banque banque = new Banque()
            {
                Nom = "Brussels Bank"
            };

            banque.Ajouter(courant);
            //banque.Ajouter(courant2);

            banque["00001"].LigneDeCredit = -500;
            banque["00001"].Depot(-200);
            banque["00001"].Depot(500);            
            banque["00001"].Retrait(-100);
            banque["00001"].Retrait(701);
            banque["00001"].Retrait(700);

            //banque["00002"].Depot(300);
            epargne.Depot(300);
            epargne.Retrait(100);
            epargne.Retrait(300);



            Console.WriteLine($"le solde du compte {banque["00001"].Numero} est : {banque["00001"].Solde}");
            Console.WriteLine($"Avoir des comptes de Mr {titulaire.Nom} {titulaire.Prenom} : {banque.AvoirDesComptes(titulaire)}");
        } 
    }
}
