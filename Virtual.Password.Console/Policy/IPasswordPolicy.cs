using Virtual.Password.Console.Catalog;
using Virtual.Password.Console.Random;
using Virtual.Password.Console.Strategies;

namespace Virtual.Password.Console.Policy
{
    public interface IPasswordPolicy<TCatalog, TIndex>
    {
        ILengthStrategy LengthStrategy { get; }
        ICatalog<TCatalog> Catalog { get; }
        IRandomGenerator<TIndex> RandomGenerator { get; }

        IPasswordPolicy<TCatalog, TIndex> WithLengthStategy(ILengthStrategy lengthStrategy);
        IPasswordPolicy<TCatalog, TIndex> UseCatalog(ICatalog<TCatalog> catalog);
        IPasswordPolicy<TCatalog, TIndex> UseRandom(IRandomGenerator<TIndex> randomGenerator);
    }
}