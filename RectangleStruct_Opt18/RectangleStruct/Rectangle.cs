using System;
using System.Globalization;

namespace RectangleStruct
{
    public struct Rectangle : IEquatable<Rectangle>
    {
        private const double Precision = 1e-13;

        private double width;
        private double height;

        public double Width
        {
            get => width;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ширина должна быть положительным числом");

                width = value;
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Высота должна быть положительным числом");

                height = value;
            }
        }

        public double Area => Width * Height;

        public double Perimeter => 2 * (Width + Height);

        public Rectangle(double width, double height) : this()
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            var culture = CultureInfo.GetCultureInfo("ru-RU");

            return string.Format(
                culture,
                "Прямоугольник шириной {0} см и высотой {1} см",
                Width,
                Height);
        }

        public bool Equals(Rectangle other)
        {
            return AreEqual(Width, other.Width) && AreEqual(Height, other.Height);
        }

        public override bool Equals(object obj)
        {
            if (obj is Rectangle rectangle)
                return Equals(rectangle);

            throw new ArgumentException("Объект для сравнения не является прямоугольником");
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                const int p = 23;

                hash = hash * p + Quantize(Width).GetHashCode();
                hash = hash * p + Quantize(Height).GetHashCode();

                return hash;
            }
        }

        public static bool operator ==(Rectangle x, Rectangle y) => x.Equals(y);

        public static bool operator !=(Rectangle x, Rectangle y) => !x.Equals(y);

        public static Rectangle operator *(double coefficient, Rectangle rectangle)
        {
            if (coefficient <= 0)
                throw new ArgumentException("Коэффициент подобия должен быть положительным числом");

            return new Rectangle(rectangle.Width * coefficient, rectangle.Height * coefficient);
        }

        private static bool AreEqual(double x, double y) => Quantize(x) == Quantize(y);

        private static long Quantize(double value) => (long)Math.Round(value / Precision);
    }
}
