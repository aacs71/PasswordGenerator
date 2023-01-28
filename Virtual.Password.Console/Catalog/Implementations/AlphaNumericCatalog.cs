namespace Virtual.Password.Console.Catalog.Implementations;

public class AlphaNumericCatalog : AbstractStringCatalog
{
    // ReSharper disable StringLiteralTypo
    public override string Contents => "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    // ReSharper restore StringLiteralTypo
}