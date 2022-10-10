using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class DecimalGenerator : IGenerator
    {
        private readonly Random _rand = new();
        public object Generate(Type type) => (decimal)_rand.Next();
        public bool CanGenerate(Type type) => type == typeof(decimal);
    }
}
