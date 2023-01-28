using Virtual.Password.Console.Policy;

namespace Virtual.Password.Console.Generator.Implementations;

public class StringPasswordGenerator : IPasswordGenerator<string>
{
    private readonly IPasswordPolicy<string, int> _policy;

    public StringPasswordGenerator(IPasswordPolicy<string, int> policy)
    {
        _policy = policy;
    }

    #region IPasswordGenerator<string> Members

    public string Generate()
    {
        var randomUpperLimit = _policy.Catalog.Size;

        var resultPassword = string.Empty;

        for (var i = 0; i < _policy.LengthStrategy.Max; i++)
            resultPassword = string.Concat(resultPassword,
                _policy.Catalog.GetItemAt(_policy.RandomGenerator.GenerateBetween(0,
                    (int)
                    randomUpperLimit)));

        return resultPassword;
    }

    #endregion
}