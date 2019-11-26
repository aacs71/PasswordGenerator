namespace Virtual.Password.Console.Random.Implementations
{
    public class BasicRandomGenerator : AbstractPositiveIntegerRandomGenerator
    {
        private readonly System.Random _random;

        public BasicRandomGenerator(System.Random random)
        {
            _random = random;
        }

        public BasicRandomGenerator() : this(new System.Random())
        {
        }

        protected override int Generate(int lower, int upper)
        {
            return _random.Next(lower, upper);
        }
    }
}