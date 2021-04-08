using System;
using System.Runtime.Serialization;

namespace Models
{
    [Serializable]
    public class SoldeInsuffisantException : Exception
    {
        public SoldeInsuffisantException(string message) : base(message)
        {
        }
    }
}