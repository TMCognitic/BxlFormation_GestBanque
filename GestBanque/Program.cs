using Models;
using System;

namespace GestBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne titulaire = new Personne("Morre", "Thierry", new DateTime(1974, 6, 5));
            Courant courant = new Courant("00001", 200, titulaire);
            Epargne epargne = new Epargne("00002", titulaire);
            Banque banque = new Banque("Brussels Bank");

            banque.Ajouter(courant);
            banque.Ajouter(epargne);

            if (banque["00001"] is Courant c)
            {
                try
                {
                    c.LigneDeCredit = -500;


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            try
            {
                banque["00001"].Depot(-200);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            banque["00001"].Depot(500);

            try
            {
                banque["00001"].Retrait(-100);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                banque["00001"].Retrait(701);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            banque["00001"].Retrait(700);
            banque["00002"].Depot(300);
            banque["00002"].Retrait(100);

            try
            {
                banque["00002"].Retrait(300);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"le solde du compte {banque["00001"].Numero} est : {banque["00001"].Solde}");
            Console.WriteLine($"Avoir des comptes de Mr {titulaire.Nom} {titulaire.Prenom} : {banque.AvoirDesComptes(titulaire)}");
        }
    }
}
