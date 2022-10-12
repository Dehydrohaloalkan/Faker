using Faker.Core.Interfaces;

namespace Faker.Core.Generators;

public class ComplexObjectGenerator : IGenerator
{
    public object Generate(Type type, GeneratorContext context)
    {
        var obj = CreateObject(type, context);
        return obj == null ? null : InitializeObject(obj, context);
    }

    public bool CanGenerate(Type type) => !type.IsGenericType;

    private object? CreateObject(Type type, GeneratorContext context)
    {
        var constructors = type.GetConstructors()
            .OrderByDescending(c => c.GetParameters().Length).ToList();

        foreach (var constructorInfo in constructors)
        {
            try
            {
                var args = constructorInfo.GetParameters()
                    .Select(p => context.Faker.Create(p.ParameterType)).ToArray();
                return constructorInfo.Invoke(args);
            }
            catch
            {
                // ignored
            }
        }

        try
        {
            return Activator.CreateInstance(type);
        }
        catch
        {
            // ignored
        }

        return null;
    }

    private object InitializeObject(object obj, GeneratorContext context)
    {

        obj.GetType().GetProperties()
            .Where(p => !Equals(p.GetValue(obj), GetDefaultValue(p.PropertyType)))
            .ForEach(property =>
            {
                try
                {
                    property.SetValue(obj, GetDefaultValue(property.PropertyType));
                }
                catch
                {
                    // ignored
                }
            });
        
        obj.GetType().GetFields()
            .Where(f => !Equals(f.GetValue(obj), GetDefaultValue(f.FieldType)))
            .ForEach(field =>
            {
                try
                {
                    field.SetValue(obj, GetDefaultValue(field.FieldType));
                }
                catch
                {
                    // ignored
                }
            });

        return obj;
    }

    private object? GetDefaultValue(Type type) => type.IsValueType ? Activator.CreateInstance(type) : null;
}