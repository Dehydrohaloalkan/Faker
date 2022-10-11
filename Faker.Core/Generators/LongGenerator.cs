using Faker.Core.Interfaces;
using static System.Int32;

namespace Faker.Core.Generators;

public class LongGenerator : IGenerator
{
    public object Generate(Type type, GeneratorContext context)
    {
        return (long) context.Random.Next(1, MaxValue);
    }
    public bool CanGenerate(Type type) => type == typeof(long);
}