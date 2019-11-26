using CommandLine;
using Virtual.Password.Console.Catalog;
using Virtual.Password.Console.Generator;
using Virtual.Password.Console.Generator.Implementations;
using Virtual.Password.Console.Policy;
using Virtual.Password.Console.Random;
using Virtual.Password.Console.Strategies;
using Virtual.Password.Console.Strategies.Implementations;

namespace Virtual.Password.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var parsedArguments = new PasswordGeneratorArguments();
            if (!Parser.ParseArguments(args, parsedArguments))
            {
                System.Console.WriteLine(Parser.ArgumentsUsage(typeof (PasswordGeneratorArguments), 80));
            }
            else
            {
                Generate(parsedArguments);
            }
        }


        private static void Generate(PasswordGeneratorArguments parsedArguments)
        {
            IPasswordPolicy<string, int> passwordPolicy = PasswordPolicyFactory.Create(parsedArguments.PasswordPolicy);

            if (parsedArguments.PasswordPolicy == PasswordPolicyType.User)
            {
                ILengthStrategy lengthStrategy = parsedArguments.LengthPolicy == LengthStrategyType.Fixed
                                                     ? new FixedLengthStrategy(parsedArguments.PasswordLength) as
                                                       ILengthStrategy
                                                     : new VariableLengthStrategy(parsedArguments.MinPasswordLength,
                                                                                  parsedArguments.MaxPasswordLength);
                passwordPolicy
                    .WithLengthStategy(lengthStrategy)
                    .UseCatalog(StringCatalogFactory.Create(parsedArguments.Catalog))
                    .UseRandom(RandomGeneratorFactory.Create(parsedArguments.RandomGeneration));
            }

            IPasswordGenerator<string> generator = new StringPasswordGenerator(passwordPolicy);

            for (int i = 0; i < parsedArguments.Count; i++)
            {
                System.Console.WriteLine(generator.Generate());
            }
        }
    }
}