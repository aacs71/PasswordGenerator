namespace Virtual.Password.Console.Catalog.Implementations
{
    public class CommonCharactersCatalog : AbstractStringCatalog
    {
        public override string Contents
        {
            get { return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*-_=+|;:,.?"; }
        }
    }
}