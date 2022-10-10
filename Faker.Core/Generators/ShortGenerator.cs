using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class ShortGenerator : IGenerator
    {
        private readonly Random _rand = new();
        public object Generate(Type type) => (short)_rand.Next();
        public bool CanGenerate(Type type) => type == typeof(short);
    }
}
