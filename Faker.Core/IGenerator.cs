namespace Faker.Core
{
    public interface IGenerator
    {
        object Generate(Type type);
        bool CanGenerate(Type type);
    }
}
