using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceProject
{
    /*this is the base class for our "shapes"
          so we will give it a height and width */
    abstract class Shape
    {
        public abstract double Area
        {
            get;
        }

        public Shape()
        {
            Height = 0;
            Width = 0;
            Radius = 0;
        }

        string[] ShapeType = new string[3] { "SQUARE", "RECTANGLE", "CIRCLE" };

        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }


    }

    //This is a class that is derived/inherits the traits of the Shape class
    //NOTE: We can create ALOT of classes derived from Shapes...can you think of 3 others? 
    //Project: Create 3 other shapes derived from the Shape class that calculate the areas. Google the area functions for
    //your choosen shapes if you can't remember
    class Rectangle : Shape
    {
        public Rectangle()
        {
            Type = "RECTANGLE";
        }

        public override double Area
        {
            get
            {
                return Height * Width;
            }

        }
    }

    //notice this is derived from Rectangle...that is because a square is a special kind of Rectangle. In fact we could derive ALL
    //4 sided shapes from Trapazoid!
    class Square : Rectangle
    {
        public Square()
        {
            Type = "SQUARE";
        }
    }


    class Circle : Shape
    {
        public Circle()
        {
            Type = "CIRCLE";
        }

        public override double Area
        {
            get
            {
                return 3.14 * Radius * Radius;
            }
        }
    }


    //We will create an instance of the Rectangle class and use it to calculate the area and display it.
    class UseRactangle
    {
        static void Main(string[] args)
        {
            //Square sqr = new Square();
            Rectangle Rect = new Rectangle();

            Rect.Height = 3;
            Rect.Width = 4;

            Console.WriteLine("Total area of the rectangle: {0}", Rect.Area);
            Console.ReadKey();

            Circle Circ = new Circle();

            Circ.Radius = 1;

            Console.WriteLine("Total area of the circle: {0}", Circ.Area);
            Console.ReadKey();
        }
    }
}
