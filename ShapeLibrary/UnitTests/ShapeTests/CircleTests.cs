using ShapeLibrary.Exceptions;
using ShapeLibrary.Shapes;
using System.Linq.Expressions;
using System;

namespace UnitTests.ShapeTests
{
    /// <summary>
    /// Тесты для круга
    /// </summary>
    public class CircleTests
    {
        [Theory]
        [InlineData(10)]
        [InlineData(0.5)]
        public void CalculateSquareCirkle_Success(double radius)
        {
            // Arrange
            double expected = radius * radius * Math.PI;

            Cirkle sut = new Cirkle(radius);
            
            // Act
            var actual = sut.CalculateSquare();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateSquareCirkle_InvalidCircle_NegativeRadius()
        {
            // Assert
            Assert.Throws<ShapeException>(() => new Cirkle(-1));
        }

        [Fact]
        public void CalculateSquareCirkle_InvalidCircle_NullRadius()
        {
            // Assert
            Assert.Throws<ShapeException>(() => new Cirkle(radius: 0));
        }
    }
}