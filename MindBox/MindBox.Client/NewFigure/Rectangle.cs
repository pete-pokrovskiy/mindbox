using MindBox.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Client
{
    /// <summary>
    /// Геометрическая фигура - прямоугольник (новая фигура на стороне клиента)
    /// </summary>
    public class Rectangle : IFigure
    {
        private readonly double _aSide;
        private readonly double _bSide;

        public Rectangle( double aSide, double bSide)
        {
            if (aSide < 0)
                throw new ArgumentOutOfRangeException(nameof(aSide), "Не может быть меньше нуля");

            if (bSide < 0)
                throw new ArgumentOutOfRangeException(nameof(bSide), "Не может быть меньше нуля");

            _aSide = aSide;
            _bSide = bSide;
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return _aSide * _bSide;
        }
    }
}
