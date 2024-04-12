using ShapeLibrary.Exceptions;
using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.ShapeTests
{
    /// <summary>
    /// Тесты для треугольника
    /// </summary>
    public class TriangleTests
    {
        [Theory]
        [InlineData(10 , 6 ,7)]
        [InlineData(13, 9 ,5)]
        public void CalculateSquareTriangle_Success(double a, double b, double c)
        {
            // Arrange
            double p = (a + b + c) / 2;
            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Triangle sut = new Triangle(new[] { a, b, c });

            // Act
            var actual = sut.CalculateSquare();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateSquareTriangle_InvalidTriangle()
        {
            // Assert
            Assert.Throws<ShapeException>(() => new Triangle(new[] { 1, 0.7, 3 }));
        }

        [Fact]
        public void CalculateSquareTriangle_InvalidTriangle_NullSides()
        {
            // Assert
            Assert.Throws<ShapeException>(() => new Triangle(new[] { -4, 0.7, 8 }));
        }
    }
}
