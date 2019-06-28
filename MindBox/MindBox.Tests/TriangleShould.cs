using MindBox.Logic;
using System;
using Xunit;

namespace MindBox.Tests
{
    public class TriangleShould
    {
        [Fact]
        public void ThrowExceptionWhenNotExists()
        {
            //arrange
            double aSide = 10;
            double bSide = 15;
            double cSide = 40;

            //act + assert
            Assert.Throws<Exception>(() => new Triangle(aSide, bSide, cSide));
        }

        //..остальные валидационные тесты

        [Fact]
        public void ReturnAreaBasedOnThreeSides()
        {
            //arrange
            var triangle = new Triangle(3, 4, 5);

            //act
            var area = triangle.GetArea();

            //assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void BeRightAngledOne()
        {
            //arrange
            var triangle = new Triangle(3, 4, 5);

            //act
            var isRightAngled = triangle.IsRightAngled;

            //assert
            Assert.True(isRightAngled);
        }
    }
}
