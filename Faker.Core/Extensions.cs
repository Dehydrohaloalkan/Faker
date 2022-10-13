namespace Faker.Core;

public static class Extensions
{
    public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
    {
        foreach (T item in enumeration)
        {
            action(item);
        }
    }

    public static object? DefaultValue(this Type type) => type.IsValueType ? Activator.CreateInstance(type) : null;
}