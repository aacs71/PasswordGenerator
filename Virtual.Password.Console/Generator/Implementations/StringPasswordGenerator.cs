using System;
using Virtual.Password.Console.Commons;
using Virtual.Password.Console.Policy;

namespace Virtual.Password.Console.Generator.Implementations
{
    public class StringPasswordGenerator : IPasswordGenerator<string>
    {
        private readonly IPasswordPolicy<string, int> _policy;

        public StringPasswordGenerator(
            IPasswordPolicy<string, int> policy)
        {
            _policy = policy;
        }

        public StringPasswordGenerator()
        {
        }

        #region IPasswordGenerator<string> Members

        public string Generate()
        {
            Guard.Against(_policy == null, "StringPasswordGenerator.Generate: Policy cannot be null");
            Guard.Against(_policy.LengthStrategy == null,
                          "StringPasswordGenerator.Generate: Length strategy cannot be null");
            Guard.Against(_policy.Catalog == null, "StringPasswordGenerator.Generate: Catalog cannot be null");
            Guard.Against(_policy.RandomGenerator == null,
                          "StringPasswordGenerator.Generate: RandomGenerator cannot be null");

            long randomUpperLimite = _policy.Catalog.Size;

            string resultPassword = String.Empty;

            for (int i = 0; i < _policy.LengthStrategy.Max; i++)
            {
                resultPassword = String.Concat(resultPassword,
                                               _policy.Catalog.GetItemAt(_policy.RandomGenerator.GenerateBetween(0,
                                                                                                                 (int)
                                                                                                                 randomUpperLimite)));
            }

            return resultPassword;
        }

        #endregion
    }
}