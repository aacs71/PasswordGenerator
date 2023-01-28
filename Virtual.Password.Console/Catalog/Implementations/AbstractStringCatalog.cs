using Virtual.Password.Console.Commons;

namespace Virtual.Password.Console.Catalog.Implementations;

public abstract class AbstractStringCatalog : ICatalog<string>
{
    #region ICatalog<string> Members

    public abstract string Contents { get; }

    public long Size => Contents.Length;

    public string GetItemAt(long position)
    {
        Guard.Against(position < 0, "StringCatalog.GetItemAt: position must be > 0");
        Guard.Against(position > Size, "StringCatalogGetItemAt: position must be < Size");

        return Contents.Substring((int)position, 1);
    }

    #endregion
}