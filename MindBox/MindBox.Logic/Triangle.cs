using System;
using System.Collections.Generic;
using System.Linq;

namespace MindBox.Logic
{
    /// <summary>
    /// Геометрическая фигура - треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        private readonly double _aLength;
        private readonly double _bLength;
        private readonly double _cLength;

        public Triangle( double aLength, double bLength, double cLength)
        {
            ValidateSides(aLength, bLength, cLength);

           
            _aLength = aLength;
            _bLength = bLength;
            _cLength = cLength;
        }

        private void ValidateSides(double aLength, double bLength, double cLength)
        {
            if (aLength < 0)
                throw new ArgumentOutOfRangeException(nameof(aLength), "Не может быть меньше нуля");

            if (bLength < 0)
                throw new ArgumentOutOfRangeException(nameof(bLength), "Не может быть меньше нуля");

            if (cLength < 0)
                throw new ArgumentOutOfRangeException(nameof(cLength), "Не может быть меньше нуля");

            if ((bLength + cLength) <= aLength)
                throw new Exception("Сумма длин двух сторон должна быть строго больше длины третьей стороны");

            if ((aLength + cLength) <= bLength)
                throw new Exception("Сумма длин двух сторон должна быть строго больше длины третьей стороны");

            if ((aLength + bLength) <= cLength)
                throw new Exception("Сумма длин двух сторон должна быть строго больше длины третьей стороны");

        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightAngled
        {
            get
            {
                //для определения гипотенузы
                var orderedSides = new List<double>
                {
                    _aLength,
                    _bLength,
                    _cLength
                }.OrderByDescending(s => s).ToArray();

                return orderedSides[0] * orderedSides[0] == (orderedSides[1] * orderedSides[1] + orderedSides[2] * orderedSides[2]);

            }
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            var semiPerimeter = (_aLength + _bLength + _cLength) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - _aLength) 
                                           * (semiPerimeter - _bLength) 
                                           * (semiPerimeter - _cLength));
        }
    }
}
