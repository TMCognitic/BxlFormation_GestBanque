namespace ExoDelegates
{
    public class Voiture
    {
        public string Plaque { get; private set; }

        public Voiture(string plaque)
        {
            Plaque = plaque;
        }
    }
}