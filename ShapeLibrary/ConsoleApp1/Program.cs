using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using ShapeLibrary;
using ShapeLibrary.Shapes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tr1 = new Triangle(new[] { 0.5, 2, 3 });
            var sq1 = tr1.CalculateSquare();

            
            var sq2 = tr1.CalculateSquare();

            var sqr1 = ShapeHandler.CalculateSquare(ShapeLibrary.Contracts.ShapeType.Circle, 10);

            Console.WriteLine("Hello, World!");
        }
    }
}
