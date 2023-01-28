using Virtual.Password.Console.Catalog;
using Virtual.Password.Console.Random;
using Virtual.Password.Console.Strategies.Implementations;

namespace Virtual.Password.Console.Policy.Implementations;

public class StrongStringPasswordPolicy : BaseStringPasswordPolicy
{
    private const int STRONG_PASSWORD_POLICY_DEFAULT_LENGTH = 21;

    public StrongStringPasswordPolicy()
        : base(
            new FixedLengthStrategy(STRONG_PASSWORD_POLICY_DEFAULT_LENGTH),
            StringCatalogFactory.Create(CatalogType.PrintableCharacters),
            RandomGeneratorFactory.Create())
    {
    }
}