namespace Virtual.Password.Console.Strategies.Implementations
{
    public class FixedLengthStrategy : ILengthStrategy
    {
        public const int DEFAULT_PASSWORD_LENGTH = 10;

        private readonly int _length;

        public FixedLengthStrategy(int length)
        {
            _length = length;
        }

        public FixedLengthStrategy() : this(DEFAULT_PASSWORD_LENGTH)
        {
        }

        #region ILengthStrategy Members

        public int Max
        {
            get { return _length; }
        }

        #endregion
    }
}