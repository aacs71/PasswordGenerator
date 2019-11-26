namespace Virtual.Password.Console.Catalog.Implementations
{
    public class LowerCaseLettersCatalog : AbstractStringCatalog
    {
        public override string Contents
        {
            get { return "abcdefghijklmnopqrstuvwxyz"; }
        }
    }
}