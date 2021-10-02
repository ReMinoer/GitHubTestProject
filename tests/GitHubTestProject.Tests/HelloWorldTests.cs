using FluentAssertions;
using NUnit.Framework;

namespace GitHubTestProject.Tests
{
    public class HelloWorldTests
    {
        [Test]
        public void Test1()
        {
            HelloWorld.Get().Should().Be("Hello World !");
        }
    }
}