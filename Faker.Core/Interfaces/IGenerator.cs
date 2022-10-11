namespace Faker.Core.Interfaces;

public interface IGenerator
{
    object Generate(Type type, GeneratorContext context);
    bool CanGenerate(Type type);
}