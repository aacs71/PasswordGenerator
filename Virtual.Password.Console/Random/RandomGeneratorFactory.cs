using Virtual.Password.Console.Random.Implementations;

namespace Virtual.Password.Console.Random;

public static class RandomGeneratorFactory
{
    private const RandomGeneratorType DEFAULT_RANDOM_GENERATOR_TYPE = RandomGeneratorType.Strong;

    public static IRandomGenerator<int> Create(RandomGeneratorType type = DEFAULT_RANDOM_GENERATOR_TYPE)
    {
        return type switch
        {
            RandomGeneratorType.Basic => new BasicRandomGenerator(),
            RandomGeneratorType.Strong => new MersenneTwister(),
            _ => throw new InvalidRandomGeneratorTypeException()
        };
    }
}