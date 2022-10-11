using Faker.Core.Interfaces;
using static System.Int32;

namespace Faker.Core.Generators;

public class IntGenerator : IGenerator
{
    public object Generate(Type type, GeneratorContext context)
    {
        return context.Random.Next(1, MaxValue);
    }

    public bool CanGenerate(Type type) => type == typeof(int);
}