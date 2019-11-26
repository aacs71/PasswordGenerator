using System;
using System.Runtime.Serialization;

namespace Virtual.Password.Console.Catalog
{
    public class InvalidCatalogTypeException : Exception
    {
        public InvalidCatalogTypeException()
        {
        }

        public InvalidCatalogTypeException(string message) : base(message)
        {
        }

        public InvalidCatalogTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidCatalogTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}