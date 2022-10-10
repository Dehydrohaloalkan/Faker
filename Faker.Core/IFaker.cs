namespace Faker.Core
{
    public interface IFaker
    {
        T Cteate<T>();
        object Cteate(Type type);
    }
}
