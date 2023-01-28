using Virtual.Password.Console.Policy.Implementations;

namespace Virtual.Password.Console.Policy;

public static class PasswordPolicyFactory
{
    public static IPasswordPolicy<string, int> Create(PasswordPolicyType type = PasswordPolicyType.Default)
    {
        return type switch
        {
            PasswordPolicyType.User => new DefaultStringPasswordPolicy(),
            PasswordPolicyType.Default => new DefaultStringPasswordPolicy(),
            PasswordPolicyType.Medium => new MediumStringPasswordPolicy(),
            PasswordPolicyType.Strong => new StrongStringPasswordPolicy(),
            _ => throw new InvalidPasswordPolicyTypeException()
        };
    }
}