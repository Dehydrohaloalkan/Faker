using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class CharGenerator : IGenerator
    {
        private readonly Random _rand = new();
        private readonly Char[] _chars = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public object Generate(Type type) => _chars[_rand.Next(0, _chars.Length)];
        public bool CanGenerate(Type type) => type == typeof(char);
    }
}
