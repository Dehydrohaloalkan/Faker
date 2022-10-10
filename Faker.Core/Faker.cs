using Faker.Core.Generators;
using Faker.Core.Interfaces;

namespace Faker.Core
{
    public class Faker : IFaker
    {
        private IEnumerable<IGenerator> _generators;

        public Faker()
        {
            _generators = new List<IGenerator> { new IntGenerator() } ;
        }

        public T Create<T>()
        {
            var obj = _generators.First(g => g.CanGenerate(typeof(T))).Generate(typeof(T));
            
            


            return (T)obj;
        }
    }
}