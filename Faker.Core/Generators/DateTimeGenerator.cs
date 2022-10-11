using Faker.Core.Interfaces;

namespace Faker.Core.Generators;

public class DateTimeGenerator : IGenerator
{
    public object Generate(Type type, GeneratorContext context)
    {
        return new DateTime(context.Random.Next());
    }
    public bool CanGenerate(Type type) => type == typeof(DateTime);
}