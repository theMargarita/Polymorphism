namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Square square = new Square();
            Triangle triangle = new Triangle();

            Geometry[] geometrys = { circle, rectangle, square, triangle};

            //alot of geometry 
            //first=class, seconde=foreach varible, third=array varible
            foreach (Geometry geometry in geometrys)
            {
                geometry.Area();
                Console.WriteLine("-----------------");
            }

            //Wait before closing
            Console.ReadKey();
        }
    }
}
