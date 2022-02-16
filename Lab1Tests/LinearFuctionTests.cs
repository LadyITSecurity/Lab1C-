using Xunit;
using Lab1.Models;
using System.Collections.Generic;

namespace Lab1Tests
{
    public class LinearFuctionTests
    {
        private static IEnumerable<object[]> GetData()
        {
            var test1 = new object[] {
                0,
                1,
                0,
                new ConstantFunction() };
            return new object[][] { test1 };
        }

        [Theory]
        [MemberData("GetData")]
        public void Test(
            double constant,
            double x,
            double expectedValue,
            Function expectedDerivative)
        {
            var sut = new ConstantFunction(constant);

            var value = sut.Calculate(x);
            var derivative = sut.GetDerivative();

            Assert.Equal(expectedValue, value, 8);
            Assert.True(expectedDerivative.Equals(derivative));

        }
    }
}