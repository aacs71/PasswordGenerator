using Virtual.Password.Console.Random.Implementations;

namespace Virtual.Password.Console.Random
{
    public static class RandomGeneratorFactory
    {
        private const RandomGeneratorType DEFAULT_RANDOM_GENERATOR_TYPE = RandomGeneratorType.Strong;

        public static IRandomGenerator<int> Create()
        {
            return Create(DEFAULT_RANDOM_GENERATOR_TYPE);
        }

        public static IRandomGenerator<int> Create(RandomGeneratorType type)
        {
            switch (type)
            {
                case RandomGeneratorType.Basic:
                    return new BasicRandomGenerator();
                case RandomGeneratorType.Strong:
                    return new MersenneTwister();
            }

            throw new InvalidRandomGeneratorTypeException();
        }
    }
}