using System;
using System.Runtime.Serialization;

namespace DAO
{
    [Serializable]
    internal class Sqlxception : Exception
    {
        public Sqlxception()
        {
        }

        public Sqlxception(string message) : base(message)
        {
        }

        public Sqlxception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Sqlxception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}