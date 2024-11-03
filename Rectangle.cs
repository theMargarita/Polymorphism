namespace Polymorphism
{
    internal class Rectangle : Geometry
    {
        public double Base{ get; set; }
        public double Hight { get; set; }

        public Rectangle()
        {
            Base = 7;
            Hight = 5;

        }
        public override double Area()
        {
            double area = Base * Hight;
            Console.WriteLine($"The rectangle area: {area} area units");
            return area;
        }
    }
}
