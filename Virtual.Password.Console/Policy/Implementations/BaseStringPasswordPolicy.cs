using Virtual.Password.Console.Catalog;
using Virtual.Password.Console.Random;
using Virtual.Password.Console.Strategies;

namespace Virtual.Password.Console.Policy.Implementations;

public class BaseStringPasswordPolicy : IPasswordPolicy<string, int>
{
    private ICatalog<string> _catalog;
    private ILengthStrategy _lengthStrategyStrategy;
    private IRandomGenerator<int> _randomGenerator;

    protected BaseStringPasswordPolicy(
        ILengthStrategy lengthStrategy,
        ICatalog<string> catalog,
        IRandomGenerator<int> randomGenerator)
    {
        _lengthStrategyStrategy = lengthStrategy;
        _catalog = catalog;
        _randomGenerator = randomGenerator;
    }

    #region IPasswordPolicy<string,int> Members

    public virtual ILengthStrategy LengthStrategy => _lengthStrategyStrategy;

    public virtual ICatalog<string> Catalog => _catalog;

    public virtual IRandomGenerator<int> RandomGenerator => _randomGenerator;

    public IPasswordPolicy<string, int> WithLengthStrategy(ILengthStrategy lengthStrategy)
    {
        _lengthStrategyStrategy = lengthStrategy;

        return this;
    }

    public IPasswordPolicy<string, int> UseCatalog(ICatalog<string> catalog)
    {
        _catalog = catalog;

        return this;
    }

    public IPasswordPolicy<string, int> UseRandom(IRandomGenerator<int> randomGenerator)
    {
        _randomGenerator = randomGenerator;

        return this;
    }

    #endregion
}