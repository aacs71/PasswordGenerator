namespace Virtual.Password.Console.Random;

public interface IRandomGenerator<T>
{
    T GenerateUntil(T upper);
    T GenerateBetween(T lower, T upper);
}