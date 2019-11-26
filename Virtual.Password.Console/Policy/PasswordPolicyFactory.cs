using Virtual.Password.Console.Policy.Implementations;

namespace Virtual.Password.Console.Policy
{
    public static class PasswordPolicyFactory
    {
        public static IPasswordPolicy<string, int> Create()
        {
            return null;
        }

        public static IPasswordPolicy<string, int> Create(PasswordPolicyType type)
        {
            switch (type)
            {
                case PasswordPolicyType.User:
                case PasswordPolicyType.Default:
                    return new DefaultStringPasswordPolicy();
                case PasswordPolicyType.Medium:
                    return new MediumStringPasswordPolicy();
                case PasswordPolicyType.Strong:
                    return new StrongStringPasswordPolicy();
            }

            throw new InvalidPasswordPolicyTypeException();
        }
    }
}