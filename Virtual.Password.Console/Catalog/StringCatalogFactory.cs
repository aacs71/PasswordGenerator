using Virtual.Password.Console.Catalog.Implementations;

namespace Virtual.Password.Console.Catalog
{
    public static class StringCatalogFactory
    {
        private const CatalogType DEFAULT_CATALOG_TYPE = CatalogType.AlphaNumeric;

        public static ICatalog<string> Create()
        {
            return Create(DEFAULT_CATALOG_TYPE);
        }

        public static ICatalog<string> Create(CatalogType type)
        {
            switch (type)
            {
                case CatalogType.CommonCharecters:
                    return new CommonCharactersCatalog();
                case CatalogType.PrintableCharacters:
                    return new PrintableCharactersCatalog();
                case CatalogType.AlphaNumeric:
                    return new AlphaNumericCatalog();
                case CatalogType.LowerCase:
                    return new LowerCaseLettersCatalog();
                case CatalogType.UpperCase:
                    return new UpperCaseLettersCatalog();
            }

            throw new InvalidCatalogTypeException();
        }
    }
}