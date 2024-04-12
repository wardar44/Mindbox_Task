using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Contracts
{
    /// <summary>
    /// Тип фигуры
    /// </summary>
    public enum ShapeType
    {
        /// <summary>
        /// Неопределенный тип фигуры
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Круг
        /// </summary>
        Circle = 1,

        /// <summary>
        /// Треугольник
        /// </summary>
        Triangle = 2,
    }
}
