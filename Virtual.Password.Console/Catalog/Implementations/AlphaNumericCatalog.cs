namespace Virtual.Password.Console.Catalog.Implementations
{
    public class AlphaNumericCatalog : AbstractStringCatalog
    {
        public override string Contents
        {
            get { return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; }
        }
    }
}