using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class BoolGenerator : IGenerator
    {
        public object Generate(Type type) => true;
        public bool CanGenerate(Type type) => type == typeof(bool);
    }
}
