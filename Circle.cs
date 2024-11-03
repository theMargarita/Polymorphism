namespace Polymorphism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        public double Pi = 3.14;

        public Circle()
        {
            Radius = 4;
        }
        public override double Area()
        {
            double area = Radius * Radius * Pi;
            Console.WriteLine($"The cicle area: {area} area units");
            return area;
        }
    }
}
