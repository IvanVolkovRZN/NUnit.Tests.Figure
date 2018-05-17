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
    class TriangTests : AbstractTest
    {


        static object[] GeometricTriangle =
        {
                new object[] { 0, 0, 0 },
                new object[] { 1, 1, 1 },
                new object[] { 2, 2, 2 },
                new object[] { 3, 3, 3 },
                new object[] { 4, 4, 4 },
                new object[] { 7, 9, 12 },
                new object[] { 11, 15, 1 },
                new object[] { 5, 12, 12 },
                new object[] { 19, 16, 13 },
                new object[] { 4, 14, 9 },
                new object[] { 10, 10, 10 },
                new object[] { 20, 20, 20 }

        };


        [Test, TestCaseSource("GeometricTriangle")]
        public void TestTriangleLenght(int n, int p, int q)
        {
            Triangle triangle = new Triangle(n, p, q);
            double lenght = n + p + q;

            Assert.AreEqual(Math.Round(lenght, ROUDING), Math.Round(triangle.getLengthTriangle(), ROUDING));

        }

        [Test, TestCaseSource("GeometricTriangle")]
        public void TestTriangleArea(int n, int p, int q)
        
            {
                Triangle triangle = new Triangle(n, p, q);
                double per = 1 / 2 * (n + p + q);
                double area = Math.Sqrt(per * (per - n) * (per - p) * (per - q));

                Assert.AreEqual(Math.Round(area, 2), Math.Round(triangle.getAreaTriangle(), 2));

            }

        



    }


}
