namespace Prog_124_S23_L4_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player josh = new Player( 99, "Josh", new Mage());
            josh.Attack();


        } // Main



        public void ExampleMethod()
        {
            //Object anObject = shape1;
            //Object triangleObj = triangle;
            //Object polyObj = poly1;
            //Console.WriteLine(anObject.ToString());
            //List<Object> listOOjbect = new List<object>();
            //List<Polygon> listOfShapes = new List<Polygon>();
            //listOfShapes.Add(poly1);
            //listOfShapes.Add(triangle);

            // Create a new Shape object ( instance )

            Shape shape1 = new Shape("blue");
            // Display shape information
            Console.WriteLine(shape1.ToString());

            Polygon poly1 = new Polygon("red", 6);
            Console.WriteLine(poly1);

            Triangle triangle = new Triangle("green");
            Console.WriteLine(triangle.ToString());

            Object triangle2 = new Triangle("blue", 3);
            Console.WriteLine(triangle2.ToString());

            Triangle backToTriangle = (Triangle)triangle2;
            Object tri3 = triangle;


            // Implied implicit
            int num = 42;
            double numDecimal = num;


            // Explicit
            double dec = 5.57;
            int decToNum = (int)dec;


        }

    } // class

} // namespace