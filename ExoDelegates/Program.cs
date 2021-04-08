using System;

namespace ExoDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture("1-ABC-001");
            Voiture v2 = new Voiture("1-ABC-002");
            Carwash carwash = new Carwash();
            
            carwash.Traiter(v1);
            carwash.Traiter(v2);            
        }
    }
}
