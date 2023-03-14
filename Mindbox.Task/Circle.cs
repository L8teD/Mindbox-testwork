namespace Mindbox.Task
{
    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус круга должен быть положительным");

            this.radius = radius;
        }

        public double GetArea() => Math.PI * Math.Pow(radius, 2);
    }
}
