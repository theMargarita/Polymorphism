namespace Polymorphism
{
    internal class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 6;
        }

        public override double Area()
        {
            double area = Side * Side;
            Console.WriteLine($"The square area: {area} area units");
            return area;
        }
    }
   
}
