using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var added = new UnitTestMethods();

            //Act
            var actual = added.Addition(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 6, 4)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var subtracted = new UnitTestMethods();

            //Act
            var actual = subtracted.Subtraction(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 8, 32)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multiplied = new UnitTestMethods();

            //Act
            var actual = multiplied.Multiplication(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(42, 4, 10.5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divided = new UnitTestMethods();

            //Act
            var actual = divided.Division(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
