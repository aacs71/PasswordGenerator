using CommandLine;
using CommandLine.Text;
using Virtual.Password.Console.Catalog;
using Virtual.Password.Console.Policy;
using Virtual.Password.Console.Random;
using Virtual.Password.Console.Strategies;
using Virtual.Password.Console.Strategies.Implementations;

namespace Virtual.Password.Console;

public class PasswordGeneratorArguments
{
    [Usage(ApplicationAlias = "password-generator")]
    public static IEnumerable<Example> Usage =>
        new List<Example>
        {
            new("Generate a password depending on the arguments", new PasswordGeneratorArguments
            {
                Catalog = CatalogType.AlphaNumeric,
                Count = 10,
                LengthPolicy = LengthStrategyType.Fixed,
                RandomGeneration = RandomGeneratorType.Strong
            })
        };

    [Option("Catalog", Required = false, Default = CatalogType.AlphaNumeric,
        HelpText =
            "Characters catalog type (CommonCharecters, PrintableCharacters, AlphaNumeric, LowerCase, UpperCase")]
    public CatalogType Catalog { get; set; }

    [Option("Count", Default = 1, HelpText = "Número de passwords a gerar.")]
    public int Count { get; set; }

    [Option("LengthPolicy", Required = false, Default = LengthStrategyType.Fixed,
        HelpText = "Política para comprimento da password (Fixed | Variable)")]
    public LengthStrategyType LengthPolicy { get; set; }

    [Option("MaxPasswordLength", Default = VariableLengthStrategy.DEFAULT_MAX_PASSWORD_LENGTH,
        HelpText = "Comprimento máximo da password a gerar.")]
    public int MaxPasswordLength { get; set; }

    [Option("MinPasswordLength", Default = VariableLengthStrategy.DEFAULT_MIN_PASSWORD_LENGTH,
        HelpText = "Comprimento mínimo da password a gerar.")]
    public int MinPasswordLength { get; set; }

    [Option("PasswordLength", Default = FixedLengthStrategy.DEFAULT_PASSWORD_LENGTH,
        HelpText = "Comprimento da password a gerar.")]
    public int PasswordLength { get; set; }

    [Option("PasswordPolicy", Default = PasswordPolicyType.User,
        HelpText =
            "Politica de geração da password (Default | Medium | Strong). Nota: Tem precedências sobre os outros parâmetros.")]
    public PasswordPolicyType PasswordPolicy { get; set; }

    [Option("RandomGeneration", Default = RandomGeneratorType.Strong,
        HelpText = "Algoritmo de geração de aleatórios (Basic | Strong).")]
    public RandomGeneratorType RandomGeneration { get; set; }
}