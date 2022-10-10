using System.Text;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators
{
    public class StringGenerator : IGenerator
    {
        private readonly Random _rand = new();
        private readonly Char[] _chars = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public object Generate(Type type)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < _rand.Next(5, 20); i++) 
                sb.Append(_chars[_rand.Next(0, _chars.Length)]);
            return sb.ToString();
        }
        public bool CanGenerate(Type type) => type == typeof(string);
    }
}
