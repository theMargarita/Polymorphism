namespace Polymorphism
{
    internal class Triangle : Geometry
    {
        public double Base { get; set; }
        public double Hight { get; set; }
        public Triangle()
        {
            Base = 7;
            Hight = 9;
        }
        public override void Area()
        {
            double area = (Base * Hight) / 2;
            Console.WriteLine($"Area of triangle: {area} area units");
        }
    }

}
