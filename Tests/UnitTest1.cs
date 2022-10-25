using Faker.Core;
using Tests.MyClasses;

namespace Tests;

public class Tests
{
    private Faker.Core.Faker _faker;

    [SetUp]
    public void Setup()
    {
        _faker = new Faker.Core.Faker();
    }

    [Test]
    [TestCase(typeof(bool))]
    [TestCase(typeof(byte))]
    [TestCase(typeof(char))]
    [TestCase(typeof(DateTime))]
    [TestCase(typeof(decimal))]
    [TestCase(typeof(double))]
    [TestCase(typeof(float))]
    [TestCase(typeof(int))]
    [TestCase(typeof(List<int>))]
    [TestCase(typeof(List<List<int>>))]
    [TestCase(typeof(long))]
    [TestCase(typeof(string))]
    [TestCase(typeof(short))]
    public void Faker_SimpleType_ReturnNotDefaultValue(Type type)
    {
        Assert.That(_faker.Create(type), Is.Not.EqualTo(type.DefaultValue()));
    }

    [Test]
    public void Faker_ComplexType_ReturnAllMembersNotDefault()
    {
        var myObject = _faker.Create<ClassA>();
        Assert.Multiple(() =>
        {
            Assert.That(myObject.Number, Is.Not.EqualTo(myObject.Number.GetType().DefaultValue()));
            Assert.That(myObject.Text, Is.Not.EqualTo(myObject.Text.GetType().DefaultValue()));
            Assert.That(myObject.Check, Is.Not.EqualTo(myObject.Check.GetType().DefaultValue()));
            Assert.That(ClassA.Static, Is.EqualTo(0));
        });
    }

    [Test]
    public void Faker_Struct_ReturnNotNullObject()
    {
        var myStruct = _faker.Create<MyStruct>();
        Assert.Multiple(() =>
        {
            Assert.That(myStruct.X, Is.Not.EqualTo(myStruct.X.GetType().DefaultValue()));
            Assert.That(myStruct.Y, Is.Not.EqualTo(myStruct.Y.GetType().DefaultValue()));
        });
    }

    [Test]
    public void Faker_ClassWithManyConstructors_ReturnUsingBiggestConstructor()
    {
        var myObject = _faker.Create<ManyConstructors>();
        Assert.That(myObject.X, Is.EqualTo(myObject.Y));
    }

    [Test]
    public void Faker_CycleClass_ReturnNotException()
    {
        Assert.DoesNotThrow(() => _faker.Create<CycleClass>());
    }

}