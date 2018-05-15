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
    public class TestClass
    {

        static object[] GeometricCircleSquare =
       {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 }

        };
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


        [Test, TestCaseSource("GeometricCircleSquare")]
        public void GeometricFigureCircleArea(int n)
        {

            Circle circle = new Circle(n);
            double area = 3.141593 * n * n;

            Assert.AreEqual(Math.Round(area, 2), Math.Round(circle.getAreaCircle(), 2));

        }

        [Test, TestCaseSource("GeometricCircleSquare")]
        public void GeometricFigureCircleLenght(int n)
        {

            Circle circle = new Circle(n);
            double lenght = 2 * 3.141593 * n;

            Assert.AreEqual(Math.Round(lenght, 2), Math.Round(circle.getLengthCircle(), 2));

        }

        [Test, TestCaseSource("GeometricCircleSquare")]
        public void GeometricFigureSquareArea(int n)
        {

            Square square = new Square(n);
            double area = n * n;

            Assert.AreEqual(Math.Round(area, 2), Math.Round(square.getAreaSquare(), 2));

        }

        [Test, TestCaseSource("GeometricCircleSquare")]
        public void GeometricFigureSquareLenght(int n)
        {

            Square square = new Square(n);
            double lenght = 4 * n;

            Assert.AreEqual(Math.Round(lenght, 2), Math.Round(square.getLengthSquare(), 2));

        }

        [Test, TestCaseSource("GeometricTriangle")]
        public void GeometricFigureTriangleLenght(int n, int p, int q)
        {
            Triangle triangle = new Triangle(n, p, q);
            double lenght = n + p + q;

            Assert.AreEqual(Math.Round(lenght, 2), Math.Round(triangle.getLengthTriangle(), 2));

        }

        [Test, TestCaseSource("GeometricTriangle")]
        public void GeometricFigureTriangleArea(int n, int p, int q)
        {
            Triangle triangle = new Triangle(n, p, q);
            double per = 1 / 2 * (n + p + q);
            double area = Math.Sqrt(per * (per - n) * (per - p) * (per - q));

            Assert.AreEqual(Math.Round(area, 2), Math.Round(triangle.getAreaTriangle(), 2));

        }


        [Test]
        public void TestTriangleAreaFull()
        {

            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    for (int k = 0; k <= 20; k++)
                    {
                        try
                        {
                            Triangle triangle = new Triangle(i, j, k);
                            double per = 1 / 2 * (i + j + k);
                            double area = Math.Sqrt(per * (per - i) * (per - j) * (per - k));
                            Assert.AreEqual(Math.Round(area, 2), Math.Round(triangle.getAreaTriangle(), 2));
                            Console.WriteLine("Not Error for data ( {0} ,{1}, {2} ) ", i, j, k);
                        }

                        catch
                        {
                            Console.WriteLine("ERROR for data ( {0} ,{1}, {2} ) ", i, j, k);

                        }

                    }

                }

            }
        }

        [Test]
        public void TestTriangleLenghtFull()
        {

            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    for (int k = 0; k <= 20; k++)
                    {
                        try
                        {
                            Triangle triangle = new Triangle(i, j, k);
                            double lenght = i + j + k;
                            Assert.AreEqual(Math.Round(lenght, 2), Math.Round(triangle.getLengthTriangle(), 2));
                            Console.WriteLine("Not Error for data ( {0} ,{1}, {2} ) ", i, j, k);
                        }

                        catch
                        {
                            Console.WriteLine("ERROR for data ( {0} ,{1}, {2} ) ", i, j, k);

                        }

                    }

                }

            }
        }


        [Test]
        public void TestCircleLetter()
        {
            Exception exception = null;
            try
            {
                Circle circle = new Circle(Convert.ToInt32("incorrect type"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }

        [Test]
        public void TestCirclNumberdouble()
        {
            Exception exception = null;
            try
            {
                Circle circle = new Circle(Convert.ToInt32("2.57"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }

        [Test]
        public void TestCirclNumberMines()
        {
            Exception exception = null;
            try
            {
                Circle circle = new Circle(-876);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNotNull(exception);
        }

        [Test]
        public void TestSquareLetter()
        {
            Exception exception = null;
            try
            {
                Square circle = new Square(Convert.ToInt32("incorrect type"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }

        [Test]
        public void TestSquareNumberdouble()
        {
            Exception exception = null;
            try
            {
                Square circle = new Square(Convert.ToInt32("2.57"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }

        [Test]
        public void TestSquareNumberMines()
        {
            Exception exception = null;
            try
            {
                Square circle = new Square(-876);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNotNull(exception);
        }
        [Test]
        public void TestTriangleLetter()
        {
            Exception exception = null;
            try
            {
                Triangle circle = new Triangle(Convert.ToInt32("incorrect type"), Convert.ToInt32("incorrect type"), Convert.ToInt32("incorrect type"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }

        [Test]
        public void TestTriangleNumberdouble()
        {
            Exception exception = null;
            try
            {
                Triangle circle = new Triangle(Convert.ToInt32("5.78"), Convert.ToInt32("2.43"), Convert.ToInt32("4.56"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }

        [Test]
        public void TestTriangleNumberMines()
        {
            Exception exception = null;
            try
            {
                Triangle circle = new Triangle(-89, -897, -1);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNotNull(exception);
        }

    }
