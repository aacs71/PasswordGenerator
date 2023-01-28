using System.Runtime.Serialization;

namespace Virtual.Password.Console.Strategies;

public class InvalidLengthTypeStrategyException : Exception
{
    public InvalidLengthTypeStrategyException()
    {
    }

    public InvalidLengthTypeStrategyException(string message) : base(message)
    {
    }

    public InvalidLengthTypeStrategyException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected InvalidLengthTypeStrategyException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}