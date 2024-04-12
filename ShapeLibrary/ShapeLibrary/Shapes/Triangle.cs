using ShapeLibrary.Contracts;
using ShapeLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public sealed class Triangle : Shape
    {
        /// <summary>
        /// Создание треугольника по трем сторонам
        /// </summary>
        /// <param name="sides"></param>
        public Triangle(double[] sides)
        {
            Validate(sides);
            SideA = sides[0];
            SideB = sides[1];
            SideC = sides[2];
        }
        /// <summary>
        /// Площадь треугольника
        /// </summary>
        public double Square;

        /// <summary>
        /// катет А
        /// </summary>
        public double SideA { get; init; }

        /// <summary>
        /// катет В
        /// </summary>
        public double SideB { get; init; }

        /// <summary>
        /// гипотенуза С
        /// </summary>
        public double SideC { get; init; }

        public override ShapeType Type => ShapeType.Triangle;

        /// <summary>
        /// Проверка на прямоугольный треугольник
        /// </summary>
        public bool IsTriangleRight()
        {
            
            if (SideC * SideC == (SideA * SideA) + (SideB * SideB))
                return true;
            else return false;

           // throw new ShapeException("Не заданы стороны треугольника");
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override double CalculateSquare( )
        {
            // проверка на прямоугольный треугольник
            if (IsTriangleRight() == true)
            {
                Square = 0.5 * SideA * SideB;
                return Square;
            }
            else
            {
                double p = (SideA + SideB + SideC) / 2;
                Square = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
                return Square;
            }
           // throw new ShapeException("Не заданы стороны треугольника");
        }

        /// <summary>
        /// Валидация треугольника
        /// </summary>
        /// <param name="sides"></param>
        /// <exception cref="ShapeException"></exception>
        private void Validate(double[] sides)
        {
            if (sides == null)
                throw new ShapeException("Не заданы стороны треугольника");

            if (sides.Length != 3)
                throw new ShapeException("Не все стороны треугольника имеют значения");

            if (sides[0] <= 0 || sides[1] <= 0 || sides[2] <= 0)
                throw new ShapeException("Стороны треугольника должны быть положительными числами");

            if (sides[0] + sides[1] <= sides[2] || sides[0] + sides[2] <= sides[1] || sides[2] + sides[1] <= sides[0])
                throw new ShapeException("Треугольника с задаными сторонами не существует");
        }
    }
}
