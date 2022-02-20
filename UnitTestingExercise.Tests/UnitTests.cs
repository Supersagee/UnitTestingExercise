using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData( 1, 2, 3, 6)]
        [InlineData( 1, 2, 100, 103)]
        [InlineData( -3, -2, 6, 1)]
        [InlineData( 1, 2, -3, 0)]
        [InlineData( 0, 0, 0, 0)]
        [InlineData(-3, 0, 0, -3)]
        [InlineData( 2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new Calculator();
            // create a Calculator object
            
            //Act
            var actual = test.Add(num1, num2, num3);
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
            Assert.Equal(expected, actual);
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(5, 7, -2)]
        [InlineData(0, 7, -7)]
        [InlineData(100, 51, 49)]
        [InlineData(-6, -5, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(4, 0, 4)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(-2, 5, -10)]
        [InlineData(-4, -5, 20)]
        [InlineData(0, 0, 0)]
        [InlineData(5, 0, 0)]
        [InlineData(0, 5, 0)]
        [InlineData(4, -2, -8)]
        [InlineData(3, 2, 6)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(20, 6, 3)]
        [InlineData(0, 0, 0)]
        [InlineData(5, 0, 0)]
        [InlineData(0, 6, 0)]
        [InlineData(-10, 6, -1)]
        [InlineData(-15, -5, 3)]
        [InlineData(10, 5, 2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
