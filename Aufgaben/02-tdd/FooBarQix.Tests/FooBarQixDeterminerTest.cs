using FluentAssertions;
using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Foo")]
        [InlineData(4, "4")]
        [InlineData(5, "Bar")]
        [InlineData(6, "Foo")]
        [InlineData(7, "Qix")]
        [InlineData(8, "8")]
        [InlineData(9, "Foo")]
        [InlineData(10, "Bar")]
        [InlineData(13, "13")]
        [InlineData(15, "FooBar")]
        [InlineData(21, "FooQix")]
        [InlineData(105, "FooBarQix")]
        public void TestDetermineFunctionShouldReturnCorrectString(int number, string expected)
        {
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            string actual = fooBarQixDeterminer.Determine(number);

            actual.Should().Be(expected);
        }
    }
}