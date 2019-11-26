namespace Virtual.Password.Console.Catalog.Implementations
{
    public class UpperCaseLettersCatalog : AbstractStringCatalog
    {
        public override string Contents
        {
            get { return "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
        }
    }
}