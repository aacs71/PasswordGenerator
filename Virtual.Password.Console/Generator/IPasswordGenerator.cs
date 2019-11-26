namespace Virtual.Password.Console.Generator
{
    public interface IPasswordGenerator<TCatalog>
    {
        TCatalog Generate();
    }
}