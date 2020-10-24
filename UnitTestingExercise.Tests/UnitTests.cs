using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 5, 0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test1 = new UnitTestMethods();


            //Act
            var actual1 = test1.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual1);

        }

        [Theory]
        [InlineData(3, 4, 12)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test2 = new UnitTestMethods();


            //Act
            var actual2 = test2.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual2);

        }

        [Theory]
        [InlineData(12, 2, 6)]
        [InlineData(9, 3, 3)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();


            //Act
            var actual3 = test3.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual3);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var expected = 'r';
            //Act

            //Assert
            Assert.Equal(expected, actual);
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
