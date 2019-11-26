using Virtual.Password.Console.Catalog;
using Virtual.Password.Console.Random;
using Virtual.Password.Console.Strategies;

namespace Virtual.Password.Console.Policy.Implementations
{
    public class DefaultStringPasswordPolicy : BaseStringPasswordPolicy
    {
        public DefaultStringPasswordPolicy()
            : base(
                LengthStrategyFactory.Create(),
                StringCatalogFactory.Create(),
                RandomGeneratorFactory.Create())
        {
        }
    }
}