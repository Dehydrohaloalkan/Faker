using Faker.Core.Interfaces;

namespace Faker.Core.Generators;

public class FloatGenerator : IGenerator
{
    public object Generate(Type type, GeneratorContext context)
    {
        return (float) context.Random.NextDouble() * 10 + 1;
    }
    public bool CanGenerate(Type type) => type == typeof(float);
}