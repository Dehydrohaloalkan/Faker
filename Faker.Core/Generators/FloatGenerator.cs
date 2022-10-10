using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class FloatGenerator : IGenerator
    {
        private readonly Random _rand = new();
        public object Generate(Type type) => (float)_rand.NextDouble();
        public bool CanGenerate(Type type) => type == typeof(float);
    }
}
