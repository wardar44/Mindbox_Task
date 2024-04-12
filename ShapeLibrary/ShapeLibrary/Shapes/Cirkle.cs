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
    /// Круг
    /// </summary>
    public sealed class Cirkle : Shape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; init; }
        
        /// <summary>
        /// Площадь круга
        /// </summary>
        public double Square;

        public override ShapeType Type => ShapeType.Circle;

        /// <summary>
        /// Создание круга через радиус
        /// </summary>
        /// <param name="radius"></param>
        public Cirkle (double radius)
        {
            Validate(radius);
            Radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns></returns>
        public override double CalculateSquare()
        {
            Square = Math.PI * Radius * Radius;
            return Square;
        }

        /// <summary>
        /// Валидация круга
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ShapeException"></exception>
        private void Validate(double radius)
        {
            if (radius == null)
                throw new ShapeException("Не задан радиус круга");

            if (radius <= 0)
                throw new ShapeException("Радиус должен быть положительным числом");
        }
    }
}
