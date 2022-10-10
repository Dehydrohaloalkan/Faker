using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class LongGenerator : IGenerator
    {
        private readonly Random _rand = new();
        public object Generate(Type type) => (long)_rand.Next();
        public bool CanGenerate(Type type) => type == typeof(long);
    }
}
