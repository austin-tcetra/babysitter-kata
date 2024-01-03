using babysitter_kata;

namespace babysitter_kata_tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var example = new Class1();
        Assert.AreEqual("Hello World", example.getGreeting());
    }
}