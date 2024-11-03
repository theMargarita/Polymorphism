namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            //Circle circle1 = new Circle();
            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            Geometry[] geometrys = { circle, rectangle, square };

            //alot of geometry 
            //first=class, seconde=foreach varible, third=array varible
            foreach (Geometry geometry in geometrys)
            {
                geometry.Area();

            }

            //Wait before closing
            Console.ReadKey();
        }
    }
}
