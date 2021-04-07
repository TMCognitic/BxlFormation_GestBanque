namespace Models
{
    public interface ICustomer
    {
        double Solde { get; }
        void Depot(double montant);
        void Retrait(double montant);
    }
}