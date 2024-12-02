namespace Polymorphism
{
    internal class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 6;
        }

        public override void Area()
        {
            double area = Side * Side;
            Console.WriteLine($"Area of square: {area} area units");
        }
    }
   
}
