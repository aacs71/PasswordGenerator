using Virtual.Password.Console.Strategies.Implementations;

namespace Virtual.Password.Console.Strategies;

public static class LengthStrategyFactory
{
    private const LengthStrategyType LENGTH_STRATEGY_TYPE = LengthStrategyType.Fixed;

    public static ILengthStrategy Create(LengthStrategyType type = LENGTH_STRATEGY_TYPE)
    {
        return type switch
        {
            LengthStrategyType.Fixed => new FixedLengthStrategy(),
            LengthStrategyType.Variable => new VariableLengthStrategy(),
            _ => throw new InvalidLengthTypeStrategyException()
        };
    }
}