namespace Models
{
    public interface IBanker : ICustomer
    {
        string Numero { get; }
        Personne Titulaire { get; }
        void AppliquerInterer();
    }
}