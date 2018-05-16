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
    class CircleTests : AbstractTest
    {
        
        [Test, TestCaseSource("GeometricCircleSquare")]
        public void GeometricFigureCircleArea(int n)
        {
            Circle circle = new Circle(n);
            double area = Math.PI * n * n;

            Assert.AreEqual(Math.Round(area, ROUDING), Math.Round(circle.getAreaCircle(), ROUDING));
        }

        [Test, TestCaseSource("GeometricCircleSquare")]
        public void GeometricFigureCircleLenght(int n)
        {
            Circle circle = new Circle(n);
            double lenght = 2 * Math.PI * n;

            Assert.AreEqual(Math.Round(lenght, ROUDING), Math.Round(circle.getLengthCircle(), ROUDING));
         }
    }
}
