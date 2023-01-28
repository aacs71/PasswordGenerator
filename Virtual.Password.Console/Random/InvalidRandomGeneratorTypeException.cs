using System.Runtime.Serialization;

namespace Virtual.Password.Console.Random;

public class InvalidRandomGeneratorTypeException : Exception
{
    public InvalidRandomGeneratorTypeException()
    {
    }

    public InvalidRandomGeneratorTypeException(string message) : base(message)
    {
    }

    public InvalidRandomGeneratorTypeException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected InvalidRandomGeneratorTypeException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}