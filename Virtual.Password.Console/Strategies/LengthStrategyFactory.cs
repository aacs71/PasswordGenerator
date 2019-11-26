using Virtual.Password.Console.Strategies.Implementations;

namespace Virtual.Password.Console.Strategies
{
    public static class LengthStrategyFactory
    {
        private const LengthStrategyType LENGTH_STRATEGY_TYPE = LengthStrategyType.Fixed;

        public static ILengthStrategy Create()
        {
            return Create(LENGTH_STRATEGY_TYPE);
        }

        public static ILengthStrategy Create(LengthStrategyType type)
        {
            switch (type)
            {
                case LengthStrategyType.Fixed:
                    return new FixedLengthStrategy();
                case LengthStrategyType.Variable:
                    return new VariableLengthStrategy();
            }

            throw new InvalidLengthTypeStrategyException();
        }
    }
}