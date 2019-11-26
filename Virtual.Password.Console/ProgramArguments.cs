using CommandLine;
using Virtual.Password.Console.Catalog;
using Virtual.Password.Console.Policy;
using Virtual.Password.Console.Random;
using Virtual.Password.Console.Strategies;
using Virtual.Password.Console.Strategies.Implementations;

namespace Virtual.Password.Console
{
    public class PasswordGeneratorArguments
    {
        [Argument(ArgumentType.AtMostOnce,
            HelpText =
                "Catálogo de dados (CommonCharecters | PrintableCharacters | AlphaNumeric | LowerCase | UpperCase.)",
            DefaultValue = CatalogType.AlphaNumeric)] public CatalogType Catalog;

        [Argument(ArgumentType.AtMostOnce, HelpText = "Número de passwords a gerar.", DefaultValue = 1)] public int
            Count;

        [Argument(ArgumentType.AtMostOnce, HelpText = "Política para comprimento da password (Fixed | Variable).",
            DefaultValue = LengthStrategyType.Fixed)] public LengthStrategyType LengthPolicy;

        [Argument(ArgumentType.AtMostOnce, HelpText = "Comprimento máximo da password a gerar.",
            DefaultValue = VariableLengthStrategy.DEFAULT_MAX_PASSWORD_LENGTH)] public int MaxPasswordLength;

        [Argument(ArgumentType.AtMostOnce, HelpText = "Comprimento mínimo da password a gerar.",
            DefaultValue = VariableLengthStrategy.DEFAULT_MIN_PASSWORD_LENGTH)] public int MinPasswordLength;

        [Argument(ArgumentType.AtMostOnce, HelpText = "Comprimento da password a gerar.",
            DefaultValue = FixedLengthStrategy.DEFAULT_PASSWORD_LENGTH)] public int PasswordLength;

        [Argument(ArgumentType.AtMostOnce,
            HelpText =
                "Politica de geração da password (Default | Medium | Strong). Nota: Tem precedências sobre os outros parâmetros"
            ,
            ShortName = "pol", DefaultValue = PasswordPolicyType.User)] public PasswordPolicyType PasswordPolicy;

        [Argument(ArgumentType.AtMostOnce, HelpText = "Algoritmo de geração de aleatórios (Basic | Strong).",
            ShortName = "rg", DefaultValue = RandomGeneratorType.Strong)] public RandomGeneratorType RandomGeneration;
    }
}