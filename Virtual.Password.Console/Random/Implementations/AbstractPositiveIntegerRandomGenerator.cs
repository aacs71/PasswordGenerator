using Virtual.Password.Console.Commons;

namespace Virtual.Password.Console.Random.Implementations;

public abstract class AbstractPositiveIntegerRandomGenerator : IRandomGenerator<int>
{
    protected abstract int Generate(int lower, int upper);

    #region IRandomGenerator<int> Members

    public virtual int GenerateUntil(int upper)
    {
        return GenerateBetween(0, upper);
    }

    public virtual int GenerateBetween(int lower, int upper)
    {
        Guard.Against(lower < 0, "RandomGenerator.GenerateBetween: lower bound must be >= 0");

        return Generate(lower, upper);
    }

    #endregion
}