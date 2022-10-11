using System.Text;
using Faker.Core.Interfaces;

namespace Faker.Core.Generators;

public class StringGenerator : IGenerator
{
    private readonly Char[] _chars = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    public object Generate(Type type, GeneratorContext context)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < context.Random.Next(5, 20); i++) 
            sb.Append(_chars[context.Random.Next(0, _chars.Length)]);
        return sb.ToString();
    }
    public bool CanGenerate(Type type) => type == typeof(string);
}