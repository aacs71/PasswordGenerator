using Virtual.Password.Console.Catalog.Implementations;

namespace Virtual.Password.Console.Catalog;

public static class StringCatalogFactory
{
    private const CatalogType DEFAULT_CATALOG_TYPE = CatalogType.AlphaNumeric;

    public static ICatalog<string> Create(CatalogType type = DEFAULT_CATALOG_TYPE)
    {
        return type switch
        {
            CatalogType.CommonCharacters => new CommonCharactersCatalog(),
            CatalogType.PrintableCharacters => new PrintableCharactersCatalog(),
            CatalogType.AlphaNumeric => new AlphaNumericCatalog(),
            CatalogType.LowerCase => new LowerCaseLettersCatalog(),
            CatalogType.UpperCase => new UpperCaseLettersCatalog(),
            _ => throw new InvalidCatalogTypeException()
        };
    }
}