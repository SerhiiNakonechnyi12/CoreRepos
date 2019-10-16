using System;

/*
 * Определение абстрактных свойств
 */
namespace AbstractClassExample
{
    // compile with: csc -target:library abstractshape.cs
    public abstract class Shape
    {
        private string name;

        public Shape(string s)
        {
            // calling the set accessor of the Id property.
            Id = s;
        }

        public string Id
        {
            get { return name; }
            set { name = value; }
        }

        // Area is a read-only property - only a get accessor is needed:
        public abstract double Area
        {
            get;
        }

        public override string ToString()
        {
            return $"{Id} Area = {Area:F2}";
        }
    }

    // compile with: csc -target:library -reference:abstractshape.dll shapes.cs
    public class Square : Shape
    {
        private int side;

        public Square(int side, string id)
            : base(id)
        {
            this.side = side;
        }

        public override double Area
        {
            get
            {
                // Given the side, return the area of a square:
                return side * side;
            }
        }
    }

    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius, string id)
            : base(id)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                // Given the radius, return the area of a circle:
                return radius * radius * System.Math.PI;
            }
        }
    }

    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height, string id)
            : base(id)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area
        {
            get
            {
                // Given the width and height, return the area of a rectangle:
                return width * height;
            }
        }
    }
    /*
    // compile with: csc -reference:abstractshape.dll;shapes.dll shapetest.cs
    class TestClass
    {
        static void Main()
        {
            Shape[] shapes =
            {
            new Square(5, "Square #1"),
            new Circle(3, "Circle #1"),
            new Rectangle( 4, 5, "Rectangle #1")
            };

            System.Console.WriteLine("Shapes Collection");
            foreach (Shape s in shapes)
            {
                System.Console.WriteLine(s);
            }
        }
    }
    */
    /* Output:
        Shapes Collection
        Square #1 Area = 25.00
        Circle #1 Area = 28.27
        Rectangle #1 Area = 20.00
    */

}

