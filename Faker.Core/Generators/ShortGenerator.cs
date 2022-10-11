using Faker.Core.Interfaces;
using static System.Int16;

namespace Faker.Core.Generators;

public class ShortGenerator : IGenerator
{
    public object Generate(Type type, GeneratorContext context)
    {
        return (short) context.Random.Next(1, MaxValue);
    }
    public bool CanGenerate(Type type) => type == typeof(short);
}