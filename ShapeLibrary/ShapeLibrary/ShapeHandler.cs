using ShapeLibrary.Contracts;
using ShapeLibrary.Exceptions;
using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    /// <summary>
    /// Обработчик фигур
    /// </summary>
    public static class ShapeHandler
    {
        /// <summary>
        /// Вычисление площади фигуры без указания типа фигуры
        /// </summary>
        /// <param name="shapeType">тип фигуры</param>
        /// <param name="parametrs">параметры</param>
        /// <returns></returns>
        public static double CalculateSquare(ShapeType shapeType, params double[] parametrs)
        {
            var shape = GetShape(shapeType, parametrs);
            return shape.CalculateSquare();
        }

        /// <summary>
        /// Возвращает тип фигуры
        /// </summary>
        /// <param name="shapeType"></param>
        /// <param name="parametrs"></param>
        /// <returns></returns>
        /// <exception cref="ShapeException"></exception>
        private static Shape GetShape(ShapeType shapeType, double[] parametrs)
        {
            return shapeType switch
            {
                ShapeType.Circle => new Cirkle(parametrs[0]),
                ShapeType.Triangle => new Triangle(parametrs),
                _ => throw new ShapeException(""),
            };
        }
    }
}
