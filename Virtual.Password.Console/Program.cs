using CommandLine;
using Virtual.Password.Console;
using Virtual.Password.Console.Catalog;
using Virtual.Password.Console.Generator.Implementations;
using Virtual.Password.Console.Policy;
using Virtual.Password.Console.Random;
using Virtual.Password.Console.Strategies;
using Virtual.Password.Console.Strategies.Implementations;

var parser = new Parser(with =>
{
    with.CaseInsensitiveEnumValues = true;
    with.HelpWriter = Console.Out;
});

parser.ParseArguments<PasswordGeneratorArguments>(args).WithParsed(Generate);

static void Generate(PasswordGeneratorArguments parsedArguments)
{
    var passwordPolicy = PasswordPolicyFactory.Create(parsedArguments.PasswordPolicy);

    if (parsedArguments.PasswordPolicy == PasswordPolicyType.User)
    {
        ILengthStrategy lengthStrategy = parsedArguments.LengthPolicy == LengthStrategyType.Fixed
            ? new FixedLengthStrategy(parsedArguments.PasswordLength)
            : new VariableLengthStrategy(parsedArguments.MinPasswordLength,
                parsedArguments.MaxPasswordLength);
        passwordPolicy
            .WithLengthStrategy(lengthStrategy)
            .UseCatalog(StringCatalogFactory.Create(parsedArguments.Catalog))
            .UseRandom(RandomGeneratorFactory.Create(parsedArguments.RandomGeneration));
    }

    var generator = new StringPasswordGenerator(passwordPolicy);

    for (var i = 0; i < parsedArguments.Count; i++) Console.WriteLine(generator.Generate());
}