namespace Virtual.Password.Console.Catalog;

public interface ICatalog<T>
{
    T Contents { get; }
    long Size { get; }
    T GetItemAt(long position);
}