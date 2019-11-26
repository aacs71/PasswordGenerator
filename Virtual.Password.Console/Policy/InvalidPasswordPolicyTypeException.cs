using System;
using System.Runtime.Serialization;

namespace Virtual.Password.Console.Policy
{
    public class InvalidPasswordPolicyTypeException : Exception
    {
        public InvalidPasswordPolicyTypeException()
        {
        }

        public InvalidPasswordPolicyTypeException(string message) : base(message)
        {
        }

        public InvalidPasswordPolicyTypeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected InvalidPasswordPolicyTypeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}