using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigures;

namespace NUnit.Tests.Figure
{
    [TestFixture]
    class SquareTests : AbstractTest
    {
        [Test, TestCaseSource("GeometricCircleSquare")]
        public void TestSquareArea(int n)
        {

            Square square = new Square(n);
            double area = n * n;

            Assert.AreEqual(Math.Round(area, ROUDING), Math.Round(square.getAreaSquare(), ROUDING));

        }

        [Test, TestCaseSource("GeometricCircleSquare")]
        public void TestSquareLenght(int n)
        {

            Square square = new Square(n);
            double lenght = 4 * n;

            Assert.AreEqual(Math.Round(lenght, ROUDING), Math.Round(square.getLengthSquare(), ROUDING));

        }

        [Test]  // Неготивный тест с отрицательным числом
        public void TestSquareNegativeNumber()
        {
            Exception exception = null;
            try
            {
                Square square = new Square(-9);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }
    }
}
