namespace Polymorphism
{
    //inherite the geometry class 
    internal class Rectangle : Geometry
    {
        //adds 
        public double Base{ get; set; }
        public double Hight { get; set; }

        public Rectangle()
        {
            Base = 7;
            Hight = 5;

        }
        //using override to use the same method but change the "value" of this class method
        //and 
        public override void Area()
        {
            double area = Base * Hight;
            Console.WriteLine($"Area of rectangle: {area} area units");
        }
    }
}
