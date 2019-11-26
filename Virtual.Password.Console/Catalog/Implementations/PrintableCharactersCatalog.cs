namespace Virtual.Password.Console.Catalog.Implementations
{
    public class PrintableCharactersCatalog : AbstractStringCatalog
    {
        public override string Contents
        {
            get { return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789`~!@#$%^&*()-_=+[]{}\\|;:'\",<.>/?"; }
        }
    }
}