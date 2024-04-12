using ShapeLibrary.Contracts;

namespace ShapeLibrary.Shapes
{
    /// <summary>
    /// Фигура
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public abstract ShapeType Type { get; }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        public abstract double CalculateSquare();

    }
}
