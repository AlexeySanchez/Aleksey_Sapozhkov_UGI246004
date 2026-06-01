using NUnit.Framework;
using RectangleStruct;
using System;

namespace RectangleStruct.UnitTests
{
    [TestFixture]
    public class RectangleTests
    {
        private const double Precision = 1e-13;

        [Test]
        public void ConstructorTest()
        {
            var rectangle = new Rectangle(2.5, 4.0);

            Assert.That(rectangle.Width, Is.EqualTo(2.5).Within(Precision));
            Assert.That(rectangle.Height, Is.EqualTo(4.0).Within(Precision));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WidthSet_ZeroOrNegativeValue_ArgumentException(double value)
        {
            var rectangle = new Rectangle(1, 1);

            Assert.That(() => rectangle.Width = value, Throws.ArgumentException);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void HeightSet_ZeroOrNegativeValue_ArgumentException(double value)
        {
            var rectangle = new Rectangle(1, 1);

            Assert.That(() => rectangle.Height = value, Throws.ArgumentException);
        }

        [TestCase(2.5, 4.0, 10.0)]
        [TestCase(3.2, 5.5, 17.6)]
        public void AreaTest(double width, double height, double result)
        {
            var rectangle = new Rectangle(width, height);

            Assert.That(rectangle.Area, Is.EqualTo(result).Within(Precision));
        }

        [TestCase(2.5, 4.0, 13.0)]
        [TestCase(3.2, 5.5, 17.4)]
        public void PerimeterTest(double width, double height, double result)
        {
            var rectangle = new Rectangle(width, height);

            Assert.That(rectangle.Perimeter, Is.EqualTo(result).Within(Precision));
        }

        [Test]
        public void ToStringTest()
        {
            var rectangle = new Rectangle(2.3451, 1.002);

            Assert.That(
                rectangle.ToString(),
                Is.EqualTo("Прямоугольник шириной 2,3451 см и высотой 1,002 см"));
        }

        [TestCase(2.5, 4.0, 2.5, 4.0, true)]
        [TestCase(2.5, 4.0, 2.5, 5.0, false)]
        [TestCase(2.5, 4.0, 3.0, 4.0, false)]
        public void Equals_TwoRectangles_ExpectedResult(
            double width1,
            double height1,
            double width2,
            double height2,
            bool result)
        {
            var rectangle1 = new Rectangle(width1, height1);
            var rectangle2 = new Rectangle(width2, height2);

            Assert.That(rectangle1.Equals(rectangle2), Is.EqualTo(result));
        }

        [Test]
        public void Equals_WrongArgument_ArgumentException()
        {
            var rectangle = new Rectangle(2.5, 4.0);
            var obj = new object();

            Assert.That(() => rectangle.Equals(obj), Throws.ArgumentException);
        }

        [Test]
        public void GetHashCodeTest()
        {
            var rectangle1 = new Rectangle(2.5, 4.0);
            var rectangle2 = new Rectangle(2.5, 4.0);

            Assert.That(rectangle1.Equals(rectangle2), Is.True);
            Assert.That(rectangle1.GetHashCode(), Is.EqualTo(rectangle2.GetHashCode()));
        }

        [Test]
        public void ComparisonOperatorsTest()
        {
            var rectangle1 = new Rectangle(2.5, 4.0);
            var rectangle2 = new Rectangle(2.5, 4.0);
            var rectangle3 = new Rectangle(3.0, 4.0);

            Assert.That(rectangle1 == rectangle2, Is.True);
            Assert.That(rectangle1 != rectangle2, Is.False);
            Assert.That(rectangle1 == rectangle3, Is.False);
            Assert.That(rectangle1 != rectangle3, Is.True);
        }

        [TestCase(2.0, 2.5, 4.0, 5.0, 8.0)]
        [TestCase(0.5, 2.5, 4.0, 1.25, 2.0)]
        public void MultiplicationTest(
            double coefficient,
            double width,
            double height,
            double resultWidth,
            double resultHeight)
        {
            var rectangle = new Rectangle(width, height);
            var result = coefficient * rectangle;

            Assert.That(result.Width, Is.EqualTo(resultWidth).Within(Precision));
            Assert.That(result.Height, Is.EqualTo(resultHeight).Within(Precision));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void Multiplication_ZeroOrNegativeCoefficient_ArgumentException(double coefficient)
        {
            var rectangle = new Rectangle(2.5, 4.0);

            Assert.That(() => coefficient * rectangle, Throws.ArgumentException);
        }
    }
}
