namespace Mindbox.Task
{
    public class Triangle : IFigure
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;

        private bool isRight;

        public bool IsRight => isRight;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (IsNotTriangleForm(firstSide, secondSide, thirdSide))
                throw new ArgumentException("Сумма двух любых сторон треугольника должна быть больше третьей");
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Стороны треугольника должны быть положительными");

            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;

            isRight = IsPythagoreanTheoremWorks();
        }

        public double GetArea()
        {
            double p = GetPerimeter();
            return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
        }

        private bool IsPythagoreanTheoremWorks()
        {
            List<double> sortedSides = new List<double>()
            {
                firstSide,
                secondSide,
                thirdSide
            }.OrderByDescending(x => x).ToList();

            return Math.Pow(sortedSides[0], 2) == Math.Pow(sortedSides[1], 2) + Math.Pow(sortedSides[2], 2);
        }

        private double GetPerimeter()
        {
            return (this.firstSide + this.secondSide + this.thirdSide) / 2d;
        }

        private bool IsNotTriangleForm(double a, double b, double c)
        {
            return CheckSides(a, b, c) || CheckSides(b, c, a) || CheckSides(c, a, b);
        }

        private bool CheckSides(double a, double b, double c) => a + b < c;
    }
}