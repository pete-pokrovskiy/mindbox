using MindBox.Logic;
using System;

namespace MindBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure triangle = new Triangle(3, 4, 6);
            var triangleArea = AreaCalcService.GetFigureArea(triangle);
            Console.WriteLine($"Площадь треугольника: { triangleArea}. Прямоугольный: {((Triangle)triangle).IsRightAngled}");

            IFigure circle = new Circle(32);
            var circleArea = AreaCalcService.GetFigureArea(circle);
            Console.WriteLine($"Площадь круга: {circleArea}");


            IFigure rectangle = new Rectangle(10, 20);
            var rectangleArea = AreaCalcService.GetFigureArea(rectangle);
            Console.WriteLine($"Площадь прямоугольника: {rectangleArea}");
        }
    }
}
