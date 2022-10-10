using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class ByteGenerator : IGenerator
    {
        private readonly Random _rand = new();
        public object Generate(Type type) => (byte)_rand.Next();
        public bool CanGenerate(Type type) => type == typeof(byte);
    }
}
