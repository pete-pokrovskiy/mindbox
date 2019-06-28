using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Logic
{
    /// <summary>
    /// Геометрическая фигура - круг
    /// </summary>
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "Не может быть меньше нуля");

            _radius = radius;
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
