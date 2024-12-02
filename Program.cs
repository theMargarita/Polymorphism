namespace Polymorphism
{
    //polymorphism means "many forms" 
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle();
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();
            Geometry triangle = new Triangle();

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
