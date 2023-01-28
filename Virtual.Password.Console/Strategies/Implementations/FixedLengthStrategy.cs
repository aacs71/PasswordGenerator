namespace Virtual.Password.Console.Strategies.Implementations;

public class FixedLengthStrategy : ILengthStrategy
{
    public const int DEFAULT_PASSWORD_LENGTH = 12;

    public FixedLengthStrategy(int length)
    {
        Max = length;
    }

    public FixedLengthStrategy() : this(DEFAULT_PASSWORD_LENGTH)
    {
    }

    #region ILengthStrategy Members

    public int Max { get; }

    #endregion
}