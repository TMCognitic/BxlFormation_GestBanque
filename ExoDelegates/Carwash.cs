using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoDelegates
{
    public class Carwash
    {
        private CarwashDelegate _delegate;

        public Carwash()
        {
            //_delegate += Preparer;
            //_delegate += Laver;
            //_delegate += Secher;
            //_delegate += Finaliser;

            _delegate += delegate (Voiture v) { Console.WriteLine($"Je prépare la voiture : {v.Plaque}"); };
            _delegate += delegate (Voiture v) { Console.WriteLine($"Je lave la voiture : {v.Plaque}"); };
            _delegate += delegate (Voiture v) { Console.WriteLine($"Je sèche la voiture : {v.Plaque}"); };
            _delegate += delegate (Voiture v) { Console.WriteLine($"Je finalise la voiture : {v.Plaque}"); };
        }

        //private void Preparer(Voiture v)
        //{
        //    Console.WriteLine($"Je prépare la voiture : {v.Plaque}");
        //}

        //private void Laver(Voiture v)
        //{
        //    Console.WriteLine($"Je lave la voiture : {v.Plaque}");
        //}

        //private void Secher(Voiture v)
        //{
        //    Console.WriteLine($"Je sèche la voiture : {v.Plaque}");
        //}

        //private void Finaliser(Voiture v)
        //{
        //    Console.WriteLine($"Je finalise la voiture : {v.Plaque}");
        //}

        public void Traiter(Voiture v)
        {
            _delegate?.Invoke(v);
        }
    }
}
