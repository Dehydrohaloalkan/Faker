namespace Faker.Core.Interfaces
{
    public interface IGenerator
    {
        object Generate(Type type);
        bool CanGenerate(Type type);
    }
}
