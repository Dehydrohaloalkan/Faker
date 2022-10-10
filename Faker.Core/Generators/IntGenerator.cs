using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class IntGenerator : IGenerator
    {
        private readonly Random _rand = new();
        public object Generate(Type type) => _rand.Next();
        public bool CanGenerate(Type type) => type == typeof(int);
    }
}
