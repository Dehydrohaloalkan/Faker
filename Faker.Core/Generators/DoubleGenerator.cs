using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class DoubleGenerator : IGenerator
    {
        private readonly Random _rand = new();
        public object Generate(Type type) => _rand.NextDouble();
        public bool CanGenerate(Type type) => type == typeof(double);
    }
}
