//Implémentation du 4ème exercice des interfaces

namespace Models
{
    public interface _IBanker : ICustomer
    {
        string Numero { get; }
        double LigneDeCredit { get; set; }
        Personne Titulaire { get; }
        void AppliquerInterer();
    }
}