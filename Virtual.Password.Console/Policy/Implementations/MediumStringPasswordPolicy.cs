using Virtual.Password.Console.Catalog;
using Virtual.Password.Console.Random;
using Virtual.Password.Console.Strategies.Implementations;

namespace Virtual.Password.Console.Policy.Implementations
{
    public class MediumStringPasswordPolicy : BaseStringPasswordPolicy
    {
        private const int MEDIUM_PASSWORD_POLICY_DEFAULT_LENGTH = 14;

        public MediumStringPasswordPolicy()
            : base(
                new FixedLengthStrategy(MEDIUM_PASSWORD_POLICY_DEFAULT_LENGTH),
                StringCatalogFactory.Create(CatalogType.CommonCharecters),
                RandomGeneratorFactory.Create())
        {
        }
    }
}