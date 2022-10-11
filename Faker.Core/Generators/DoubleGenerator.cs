using Faker.Core.Interfaces;

namespace Faker.Core.Generators;

public class DoubleGenerator : IGenerator
{
    public object Generate(Type type, GeneratorContext context)
    {
        return context.Random.NextDouble() + 1 * 10;
    }
    public bool CanGenerate(Type type) => type == typeof(double);
}