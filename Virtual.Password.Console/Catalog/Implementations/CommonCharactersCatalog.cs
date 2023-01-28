namespace Virtual.Password.Console.Catalog.Implementations;

public class CommonCharactersCatalog : AbstractStringCatalog
{
    public override string Contents =>
        // ReSharper disable StringLiteralTypo
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*-_=+|;:,.?";
    // ReSharper restore StringLiteralTypo
}